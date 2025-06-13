using CRM.Models;

namespace CRM.Services
{
    public class ClientService
    {
        private readonly List<Client> clients = new();

        public IEnumerable<Client> GetClients() => clients;

        public void AddClient(Client client)
        {
            client.Id = clients.Count > 0 ? clients.Max(c => c.Id) + 1 : 1;
            clients.Add(client);
        }

        public void UpdateClient(Client client)
        {
            var existing = clients.FirstOrDefault(c => c.Id == client.Id);
            if (existing != null)
            {
                existing.Name = client.Name;
                existing.Email = client.Email;
                existing.CompanyName = client.CompanyName;
                existing.CompanyWebsite = client.CompanyWebsite;
                existing.ContactNumber = client.ContactNumber;
                existing.LastFeedback = client.LastFeedback;
            }
        }

        public void DeleteClient(int id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                clients.Remove(client);
            }
        }
    }
}
