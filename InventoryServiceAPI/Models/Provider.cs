using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace InventoryServiceAPI.Models
{
    public class Provider
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [AllowNull]
        public string? Details { get; set; }
        [Required]
        public string? Phone { get; set; }

        public ICollection<Product> Products { get; } = [];
    }
}
