using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    public enum Status
    {
        NowPlaying,
        ComingSoon,
        Ended,
        Cancelled
    }

    [Table("schedules")]
    public class Schedule
    {
        [Key]
        [Column("schedule_id")]
        public Guid schedule_id { get; set; }

        [Required]
        public required int runtime { get; set; }

        [Required]
        public required DateTime date { get; set; }

        [Required]
        public required Status status { get; set; }

        [Required]
        [Column("movie_id")]
        public required string movieId { get; set; }

        [ForeignKey("room_id")]
        [Column("room_id")]
        [Required]
        public required virtual Guid roomId { get; set; }

        public virtual Booking? Booking { get; set; } = null;
    }
}
