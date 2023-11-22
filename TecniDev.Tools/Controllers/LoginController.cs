using TecniDev.Tools.Data.Context;
using TecniDev.Tools.Data.Models;

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
    }
}
