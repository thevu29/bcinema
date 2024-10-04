using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    public enum SeatStatus
    {
        Available,
        Pending,
        Booked,
        NotAvailable
    }

    [Table("seats")]
    public class Seat
    {
        [Key]
        [Column("seat_id")]
        public Guid seatId { get; set; } = Guid.NewGuid();

        [Required]
        public required string row { get; set; }

        [Required]
        public required int number { get; set; }

        [Required]
        public required SeatStatus status { get; set; } = SeatStatus.Available;

        [Column("create_at")]
        public DateTime createAt { get; set; } = DateTime.Now;

        [ForeignKey("seat_type_id")]
        [Column("seat_type_id")]
        [Required]
        public required virtual Guid seatTypeId { get; set; }

        [ForeignKey("room_id")]
        [Required]
        public required virtual Guid roomId { get; set; }

        public virtual BookingDetail? bookingDetail { get; set; } = null;
    }
}
