using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer
{
    public class ClientService : IClientService
    {
        public List<Client> clients { get; set; }
        private IConfiguration Configuration { get; set; }
        public ClientService(IConfiguration configuration)
        {
            clients = new List<Client>();
            Configuration = configuration;

            var appSettingsSection = Configuration.GetSection("ClientConfigurations").GetChildren();
            foreach (IConfigurationSection section in appSettingsSection)
            {
                clients.Add(new Client() { ClientSecret = Configuration[section.Path + ":ClientSecret"], CallBackUrl = Configuration[section.Path + ":CallBackUrl"],AppName= Configuration[section.Path + ":AppName"] });
            }
        }

        public Client GetConfigByGuid(string Guid)
        {
           return clients.Find(k => k.ClientSecret == Guid);
        }

        public List<Client> GetAllClients()
        {
            return clients;
        }

        public ClientContext GetClientContext(string username)
        {
            return new ClientContext()
            {
                clients = clients,
                username = username
            };
        }
    }
}
