using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class AppSettings
    {
        public string Secret { get; set; }
    }

    public class Client
    {
        public string ClientSecret { get; set; }
        public string CallBackUrl { get; set; }

        public string AppName { get; set; }

    }

    public class ClientContext
    {
        public List<Client> clients { get; set; }
        public string username { get; set; }
    }
}
