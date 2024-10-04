using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("vouchers")]
    public class Voucher
    {
        [Key]
        [Column("voucher_id")]
        public Guid voucherId { get; set; } = Guid.NewGuid();

        [Required]
        public required string code { get; set; }

        [Required]
        public required int discount { get; set; }

        [Required]
        public required int quantity { get; set; }

        public string? description { get; set; }

        [Column("create_at")]
        [Required]
        public DateTime createAt { get; set; } = DateTime.Now;

        [Column("expire_at")]
        [Required]
        public required DateTime expireAt { get; set; }

        public virtual ICollection<UserVoucher> userVouchers { get; set; } = new List<UserVoucher>();

        public virtual Booking? booking { get; set; } = null;
    }
}
