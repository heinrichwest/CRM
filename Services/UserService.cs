using CRM.Models;

namespace CRM.Services
{
    public class UserService
    {
        private readonly List<User> users = new();

        public IEnumerable<User> GetUsers() => users;

        public void AddUser(User user)
        {
            user.Id = users.Count > 0 ? users.Max(u => u.Id) + 1 : 1;
            users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existing = users.FirstOrDefault(u => u.Id == user.Id);
            if (existing != null)
            {
                existing.FirstName = user.FirstName;
                existing.LastName = user.LastName;
                existing.Email = user.Email;
                existing.Phone = user.Phone;
                existing.Address = user.Address;
                existing.Role = user.Role;
            }
        }

        public void DeleteUser(int id)
        {
            var user = users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                users.Remove(user);
            }
        }
    }
}
