using Microsoft.EntityFrameworkCore;
using System.Configuration;
using TecniDev.Tools.Data.Models;

namespace TecniDev.Tools.Data.Context
{
    internal class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseNpgsql(ConfigurationManager.ConnectionStrings["Npsql"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(32);
                entity.Property(e => e.Password).IsRequired().HasMaxLength(128);
                entity.HasOne(e => e.Role).WithMany(r => r.Users);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("roles");
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(64);
                entity.Property(e => e.Description).HasColumnType("text");
            });
        }
    }
}
