using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("user")]
    public class User
    {
        [Column("id")]
        public int Id { get; set; }

        [Required, MaxLength(100), MinLength(8)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Column("role")]
        public string UserRole { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Admin Admin { get; set; }

    }
}
