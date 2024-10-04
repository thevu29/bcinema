using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("user_id")]
        public Guid userId { get; set; } = Guid.NewGuid();

        [Required]
        public required string name { get; set; }

        [Required]
        public required string email { get; set; }

        [Required]
        public required string password { get; set; }

        public string? avatar { get; set; }

        public int point { get; set; } = 0;

        public string? provider { get; set; }

        [Column("create_at")]
        [Required]
        public DateTime creatAt { get; set; } = DateTime.Now;

        [Column("delete_at")]
        public DateTime? deleteAt { get; set; } = null;

        [ForeignKey("role_id")]
        [Column("role_id")]
        [Required]
        public required virtual Guid roleId { get; set; }

        public virtual ICollection<UserVoucher> userVouchers { get; set; } = new List<UserVoucher>();

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        public virtual ICollection<Token> tokens { get; set; } = new List<Token>();
    }
}
