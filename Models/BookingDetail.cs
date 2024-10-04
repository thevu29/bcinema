using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("booking_details")]
    public class BookingDetail
    {
        [Key]
        [Column("booking_detail_id")]
        public Guid bookingDetailId { get; set; } = Guid.NewGuid();

        [ForeignKey("booking_id")]
        [Column("booking_id")]
        [Required]
        public required virtual Guid bookingId { get; set; }

        [ForeignKey("seat_id")]
        [Column("seat_id")]
        [Required]
        public required virtual Guid seatId { get; set; }

        [ForeignKey("food_id")]
        [Column("food_id")]
        [Required]
        public required virtual Guid foodId { get; set; }

        [Required]
        [Column("food_quantity")]
        public required int foodQuantity;

        [Required]
        public required double price;
    }
}
