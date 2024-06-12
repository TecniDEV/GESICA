using Microsoft.EntityFrameworkCore;
using UserServiceAPI.Models;

namespace UserServiceAPI.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Relations One User to Many Roles (UserId -« Role) 
            modelBuilder.Entity<User>()
                .HasMany(user => user.Roles)
                .WithOne(role => role.User)
                .HasForeignKey(role => role.UserId)
                .IsRequired();

            modelBuilder.Entity<Role>()
                .HasOne(role => role.User)
                .WithMany(user => user.Roles)
                .HasForeignKey(role => role.UserId)
                .IsRequired();
            #endregion
        }
    }
}
