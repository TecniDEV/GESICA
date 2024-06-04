using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace InventoryServiceAPI.Models
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public long CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public long ProviderId { get; set; }
        public Provider Provider { get; set; } = null!;
        public long WarehouseId { get; set; }
        public Warehouse Warehouse { get; } = null!;
        [Precision(18,2)]
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }

    public class Category
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public ICollection<Product> Products { get; } = [];
    }
}
