using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("rooms")]
    public class Room
    {
        [Key]
        [Column("room_id")]
        public Guid roomId { get; set; }

        [Required]
        public required string name { get; set; }

        [Column("create_at")]
        public DateTime createAt { get; set; } = DateTime.Now;

        public virtual ICollection<Seat> seats { get; set; } = new List<Seat>();

        public virtual Schedule schedule { get; set; } = null!;
    }
}
