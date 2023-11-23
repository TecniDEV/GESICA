using TecniDev.Tools.Data.Context;
using TecniDev.Tools.Data.Models;
using TecniDev.Tools.Helpers;

namespace TecniDev.Tools.Controllers
{
    public class LoginController
    {
        public LoginController() 
        {
            var Context = new LoginContext();
            Context.Database.EnsureCreated();
        }

        public void AddUser(User user)
        {
            using var Context = new LoginContext();
            Context.Users.Add(user);
            Context.SaveChanges();
            Context.Dispose();
        }

        public void RemoveUser(User user)
        {
            using var Context = new LoginContext();
            Context.Users.Remove(user);
            Context.SaveChanges();
            Context.Dispose();
        }

        public void UpdateUser(User user) 
        {
            using var Context = new LoginContext();
            Context.Users.Update(user);
            Context.SaveChanges();
            Context.Dispose();
        }

        public List<User> GetUsers() 
        {
            using var Context = new LoginContext();
            return [.. Context.Users.ToList()];
        }

        public User? GetUser(int id)
        {
            using var Context = new LoginContext();
            return Context.Users.Find(id);
        }

        public void AddRole(Role role) 
        {
            using var Context = new LoginContext();
            Context.Roles.Add(role);
            Context.SaveChanges();
            Context.Dispose();
        }

        public void DeleteRole(Role role) 
        { 
            using var Context = new LoginContext();
            Context.Roles.Remove(role);
            Context.SaveChanges();
            Context.Dispose();
        }

        public List<Role> GetRoles() 
        {
            using var Context = new LoginContext();
            return [.. Context.Roles.ToList()];
        }

        public Role? GetRole(int id)
        {
            using var Context = new LoginContext();
            return Context.Roles.Find(id);
        }

        public static bool Login(string username, string password)
        {
            using var Context = new LoginContext();
            List<User> users = Context.Users.ToList();
            User? user = users
                .Where(u => u.Name == username && u.Password == SecurityHelper.Crypt(password))
                .SingleOrDefault();
            if (user != null)
                return true;
            return false;
        }
    }
}
