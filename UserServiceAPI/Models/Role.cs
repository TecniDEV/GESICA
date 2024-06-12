using System.ComponentModel.DataAnnotations;

namespace UserServiceAPI.Models
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        public long UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
