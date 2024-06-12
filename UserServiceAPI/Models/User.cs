using System.ComponentModel.DataAnnotations;

namespace UserServiceAPI.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        [Required] 
        public string Name { get; set; } = string.Empty;
        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;

        public IEnumerable<Role> Roles { get; set; } = [];
    }
}
