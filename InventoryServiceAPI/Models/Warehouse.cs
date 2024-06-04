using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace InventoryServiceAPI.Models
{
    public class Warehouse
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [AllowNull]
        public string? Details { get; set; }

        public ICollection<Product> Products { get; } = [];
    }

    // Intermediate Table Product_Warehouse
    public class ProductWarehouse
    {
        public long ProductId { get; set; }
        public long WarehouseId { get; set; }

        public Product Product { get; set; } = null!;
        public Warehouse Warehouse { get; set; } = null!;
    }
}
