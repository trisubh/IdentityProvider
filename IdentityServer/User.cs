using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string ClientSecret {get;set;}
    }

    public class AuthContext
    {
        public string Token { get; set; }
        public string Username { get; set; }
        public string ExpiresIn { get; set; }
        public string Role { get; set; }

    }

    public class ClientConfig
    {
        public string ClientSecret { get; set; }
        public string CallBackUrl { get; set; }
    }
}
