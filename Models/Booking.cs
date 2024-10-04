using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("bookings")]
    public class Booking
    {
        [Key]
        [Column("booking_id")]
        public Guid bookingID { get; set; }

        [Required]
        public DateTime date { get; set; } = DateTime.Now;

        [Required]
        [Column("total_price")]
        public required double totalPrice { get; set; }

        [ForeignKey("user_id")]
        [Required]
        public required virtual Guid userId { get; set; }

        [ForeignKey("schedule_id")]
        [Column("schedule_id")]
        [Required]
        public required virtual Guid scheduleId { get; set; }

        [ForeignKey("voucher_id")]
        [Column("voucher_id")]
        [Required]
        public required virtual Guid voucherId { get; set; }

        public virtual ICollection<BookingDetail> bookingDetails { get; set; } = new List<BookingDetail>();
    }
}
