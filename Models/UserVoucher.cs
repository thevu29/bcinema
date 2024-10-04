using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("user_voucher")]
    public class UserVoucher
    {
        [Key]
        public Guid id { get; set; } = Guid.NewGuid();

        [Required]
        [Column("is_used")]
        public Boolean isUsed { get; set; } = false;

        [ForeignKey("user_id")]
        [Column("user_id")]
        [Required]
        public required virtual Guid userId { get; set; }

        [ForeignKey("voucher_id")]
        [Column("voucher_id")]
        [Required]
        public required virtual Guid voucherId { get; set; }
    }
}
