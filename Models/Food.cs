using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("foods")]
    public class Food
    {
        [Key]
        [Column("food_id")]
        public Guid foodId { get; set; } = Guid.NewGuid();

        [Required]
        public required string name { get; set; }

        [Required]
        public required double price { get; set; }

        [Required]
        public required int quantity { get; set; }

        [Column("create_at")]
        public DateTime createAt { get; set; } = DateTime.Now;

        [Column("delete_at")]
        public DateTime? deleteAt { get; set; } = null;

        public virtual ICollection<BookingDetail> bookingDetails { get; set; } = new List<BookingDetail>();
    }
}
