using TecniDev.Tools.Data.Context;
using TecniDev.Tools.Data.Models;

namespace TecniDev.Tools.Controllers
{
    public class LoginController
    {
        private readonly LoginContext Context = new();

        public LoginController() 
        { 
           Context.Database.EnsureCreated();
        }

        public void Add(User user)
        {
            using (Context)
            {
                Context.Users.Add(user);
                Context.SaveChanges();
            }
        }

        public void Remove(User user)
        {
            using (Context)
            {
                Context.Users.Remove(user);
                Context.SaveChanges();
            }
        }

        public void Update(User user) 
        { 
            using (Context) 
            {
                Context.Users.Update(user);
                Context.SaveChanges(); 
            }
        }

        public ICollection<User> GetUsers() 
        {
            using(Context) 
            {
                return [.. Context.Users.ToList()];
            }
        }
    }
}
