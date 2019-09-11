using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IdentityServer
{
    public class UserController : Controller
    {
        private IUserService _userService;
        private IClientService _Service;
        ObjectCache cache = null;
        CacheItemPolicy policy = null;
        private IConfiguration Configuration { get; set; }

        public UserController(IClientService Service,IUserService userService,IConfiguration configuration)
        {
             cache = MemoryCache.Default;
             policy = new CacheItemPolicy();
            _userService = userService;
            _Service = Service;
            Configuration = configuration;
        }

        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View("Authenticate");

            
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody]User userParam)
        {
            //cache = MemoryCache.Default;
            // policy = new CacheItemPolicy();
            Client client= _Service.GetConfigByGuid(userParam.ClientSecret);
            policy.SlidingExpiration=TimeSpan.FromMinutes(30);
            string callBackUrl = string.Empty;
            var IsValidatedFromProvider= Request.Headers["IsValidatedFromProvider"];
            User _usr =!String.IsNullOrEmpty(userParam.Username) ? cache.Get(userParam.Username) as User : null;
            if (_usr == null)
            {
                var user = _userService.Authenticate(userParam.Username, userParam.Password);
                if (user == null)
                    if (IsValidatedFromProvider != "Yes")
                    {
                        return new ObjectResult(Url.Action("Login", "User", null, Url.ActionContext.HttpContext.Request.Scheme) + "?ClientSecret=" + client.ClientSecret);
                    }
                    else
                        return BadRequest(new { message = "Username or password is incorrect" });

                if (IsValidatedFromProvider == "Yes")
                {
                    callBackUrl = client.CallBackUrl + "?ClientID=" + client.ClientSecret + ",OAuth=" + user.Token + ",uid=" + user.Username + ",role="+user.Role+",Expiresin=" + 30;
                    cache.Set(userParam.Username, user, policy);
                    return new ObjectResult(callBackUrl);
                }
                //cache.Set("UserContext", user, policy);


                callBackUrl = client.CallBackUrl + "?ClientID=" + client.ClientSecret + ",OAuth=" + user.Token + ",uid=" + user.Username + ",role=" + user.Role + ",Expiresin=" + 30;
                return new ObjectResult(callBackUrl);
            }
            else
            {
                callBackUrl = client.CallBackUrl + "?ClientID=" + client.ClientSecret + ",OAuth=" + _usr.Token + ",uid=" + _usr.Username + ",role=" + _usr.Role + ",Expiresin=" + 30;
                return new ObjectResult(callBackUrl);
            }
        }



        [AllowAnonymous]
        [HttpPost("appcentre")]
        public IActionResult AppCentre([FromBody]User userParam)
        {
            //cache = MemoryCache.Default;
            // policy = new CacheItemPolicy();
            List<Client> clients = _Service.GetAllClients();
            policy.SlidingExpiration = TimeSpan.FromMinutes(30);
            string callBackUrl = string.Empty;
            var IsValidatedFromProvider = Request.Headers["IsValidatedFromProvider"];
            User _usr = !String.IsNullOrEmpty(userParam.Username) ? cache.Get(userParam.Username) as User : null;
            if (_usr == null)
            {
                var user = _userService.Authenticate(userParam.Username, userParam.Password);
                ClientContext clientcontext = _Service.GetClientContext(userParam.Username);
                if (user == null)
                    if (IsValidatedFromProvider != "Yes")
                    {
                        return new ObjectResult(Url.Action("Login", "User", null, Url.ActionContext.HttpContext.Request.Scheme) + "?ClientSecret=" + "");
                    }
                    else
                        return BadRequest(new { message = "Username or password is incorrect" });

                if (IsValidatedFromProvider == "Yes")
                {
                    callBackUrl = "http://localhost:51659/Appstore?clients="+JsonConvert.SerializeObject(clientcontext, Formatting.None);
                    cache.Set(userParam.Username, user, policy);
                    return new ObjectResult(callBackUrl);
                }
                //cache.Set("UserContext", user, policy);

                callBackUrl = "http://localhost:51659/Appstore?clients=" + JsonConvert.SerializeObject(clientcontext, Formatting.None);
                return new ObjectResult(callBackUrl);
            }
            else
            {
                ClientContext clientcontext = _Service.GetClientContext(userParam.Username);
                callBackUrl = "http://localhost:51659/Appstore?clients=" + JsonConvert.SerializeObject(clientcontext, Formatting.None);
                return new ObjectResult(callBackUrl);
            }
        }





        [AllowAnonymous]
        [HttpPost("exit")]
        public IActionResult Exit([FromBody]User userParam)
        {
            Client client = _Service.GetConfigByGuid(userParam.ClientSecret);
            string callBackUrl = client.CallBackUrl;
            User _usr = cache.Get(userParam.Username) as User;
            if (_usr != null)
            {
                //Remove/Logout from all applications from all application 
                cache.Remove(userParam.Username);
                return new ObjectResult(callBackUrl);
            }
            else
                return new ObjectResult(callBackUrl);
        }

        [AllowAnonymous]
        [HttpPost("exitfromprovider")]
        public IActionResult ExitProvider([FromBody]User userParam)
        {
            
            string callBackUrl = "http://localhost:51659/Login";
            callBackUrl = userParam.ClientSecret == "IsLoggedOff" ? "http://localhost:51659/Login?IsLoggedOff=true" : callBackUrl;
            User _usr;
            if (userParam.ClientSecret != "IsLoggedOff")
            {
                 _usr = cache.Get(userParam.Username) as User;
            }
            else
            {
                _usr = null;
            }
            if (_usr != null)
            {
                //Remove/Logout from all applications from all application 
                cache.Remove(userParam.Username);
                return new ObjectResult(callBackUrl);
            }
            else
                return new ObjectResult(callBackUrl);
        }

        [AllowAnonymous]
        [HttpPost("Logoff")]
        public IActionResult LogOff([FromBody]User userParam)
        {
            Client client = _Service.GetConfigByGuid(userParam.ClientSecret);
            string callBackUrl = client.CallBackUrl;
            return new ObjectResult(callBackUrl+"?IsLoggedOff=true");
         
        }

        [HttpGet("Appstore")]
        public IActionResult AppStore()
        {
            return View("Appstore");
        }




        [Authorize(Roles = Role.Admin)]
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetById(id);

            if (user == null)
            {
                return NotFound();
            }

            // only allow admins to access other user records
            var currentUserId = int.Parse(User.Identity.Name);
            if (id != currentUserId && !User.IsInRole(Role.Admin))
            {
                return Forbid();
            }

            return Ok(user);
        }
    }
}

