using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }

    public interface IClientService
    {
        Client GetConfigByGuid(string Guid);

        List<Client> GetAllClients();

        ClientContext GetClientContext(string username = null);
    }
}
