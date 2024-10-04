using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bcinema.Models
{
    [Table("tokens")]
    public class Token
    {
        [Key]
        [Column("token_id")]
        public Guid tokenId { get; set; } = Guid.NewGuid();

        [Required]
        [Column("refresh_token")]
        public required string refreshToken { get; set; }

        [Required]
        [Column("refresh_token_expire_at")]
        public required DateTime refreshTokenExpireAt { get; set; }

        [ForeignKey("user_id")]
        [Column("user_id")]
        [Required]
        public required virtual Guid userId { get; set; }
    }
}
