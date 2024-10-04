using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("roles")]
    public class Role
    {
        [Key]
        [Column("role_id")]
        public Guid roleId { get; set; } = Guid.NewGuid();

        [Required]
        public required string name { get; set; }

        public string? description { get; set; }

        [Column("create_at")]
        [Required]
        public DateTime createAt { get; set; } = DateTime.Now;

        public virtual ICollection<User> users { get; set; } = new List<User>();
    }
}
