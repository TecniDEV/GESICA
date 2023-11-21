using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TecniDev.Tools.Data.Models;

namespace TecniDev.Tools.Data.Context
{
    internal class LoginContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        string connectionString = ConfigurationManager.ConnectionStrings["Npsql"].ConnectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql(connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("users")
                .HasIndex(u => u.ID);
        }
    }
}
