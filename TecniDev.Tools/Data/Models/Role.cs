using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TecniDev.Tools.Data.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<User>? Users { get; set; }
    }
}
