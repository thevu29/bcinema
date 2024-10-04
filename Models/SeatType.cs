using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("seat_types")]
    public class SeatType
    {
        [Key]
        [Column("seat_type_id")]
        public Guid seatTypeId { get; set; } = Guid.NewGuid();

        [Required]
        public string name { get; set; } = "";

        [Column("create_at")]
        public DateTime createAt { get; set; } = DateTime.Now;

        public virtual ICollection<Seat> seats { get; set; } = new List<Seat>();
    }
}
