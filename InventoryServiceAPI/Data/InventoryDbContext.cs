using InventoryServiceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryServiceAPI.Data
{
    public class InventoryDbContext(DbContextOptions<InventoryDbContext> options) : DbContext(options)
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Relations One Category to Many Products (CategoryId -« Product) 
            modelBuilder.Entity<Category>()
                .HasMany(category => category.Products)
                .WithOne(product => product.Category)
                .HasForeignKey(product => product.CategoryId)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(product => product.Category)
                .WithMany(category => category.Products)
                .HasForeignKey(product => product.CategoryId)
                .IsRequired();
            #endregion

            #region Relations One Provider to Many Products (ProviderId -« Product)
            modelBuilder.Entity<Provider>()
                .HasMany(provider => provider.Products)
                .WithOne(product => product.Provider)
                .HasForeignKey(product => product.ProviderId)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(product => product.Provider)
                .WithMany(provider => provider.Products)
                .HasForeignKey(product => product.ProviderId)
                .IsRequired();
            #endregion

            #region Relations One Warehouse to Many Products (WarehouseId -« Product)
            modelBuilder.Entity<Warehouse>()
                .HasMany(warehouse => warehouse.Products)
                .WithOne(product => product.Warehouse)
                .HasForeignKey(product => product.WarehouseId)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .HasOne(product => product.Warehouse)
                .WithMany(warehouse => warehouse.Products)
                .HasForeignKey(product => product.WarehouseId)
                .IsRequired();
            #endregion
        }
    }
}
