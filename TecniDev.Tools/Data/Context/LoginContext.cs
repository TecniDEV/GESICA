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
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(32);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(255);
                entity.HasOne(e => e.Role).WithMany(r => r.Users);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(64);
                entity.Property(e => e.Description).HasField("description");
            });
        }
    }
}
