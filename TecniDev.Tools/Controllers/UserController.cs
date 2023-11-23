using TecniDev.Tools.Data.Context;
using TecniDev.Tools.Data.Models;
using TecniDev.Tools.Helpers;

namespace TecniDev.Tools.Controllers
{
    public class UserController
    {
        public UserController() 
        {
            var Context = new UserContext();
            Context.Database.EnsureCreated();
        }

        public void AddUser(User user)
        {
            using var Context = new UserContext();
            Context.Users.Add(user);
            Context.SaveChanges();
            Context.Dispose();
        }

        public void RemoveUser(User user)
        {
            using var Context = new UserContext();
            Context.Users.Remove(user);
            Context.SaveChanges();
            Context.Dispose();
        }

        public void UpdateUser(User user) 
        {
            using var Context = new UserContext();
            Context.Users.Update(user);
            Context.SaveChanges();
            Context.Dispose();
        }

        public List<User> GetUsers() 
        {
            using var Context = new UserContext();
            return [.. Context.Users];
        }

        public User? GetUser(int id)
        {
            using var Context = new UserContext();
            return Context.Users.Find(id);
        }

        public void AddRole(Role role) 
        {
            using var Context = new UserContext();
            Context.Roles.Add(role);
            Context.SaveChanges();
            Context.Dispose();
        }

        public void DeleteRole(Role role) 
        { 
            using var Context = new UserContext();
            Context.Roles.Remove(role);
            Context.SaveChanges();
            Context.Dispose();
        }

        public List<Role> GetRoles() 
        {
            using var Context = new UserContext();
            return [.. Context.Roles];
        }

        public Role? GetRole(int id)
        {
            using var Context = new UserContext();
            return Context.Roles.Find(id);
        }

        public bool Login(string username, string password)
        {
            using var Context = new UserContext();
            List<User> users = [.. Context.Users];
            User? user = users
                .Where(u => u.Name == username && u.Password == SecurityHelper.Crypt(password))
                .SingleOrDefault();
            return user != null;
        }
    }
}
