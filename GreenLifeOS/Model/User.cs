using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required, MaxLength(100), MinLength(8)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Column("role")]
        public string UserRole { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new HashSet<Customer>();
        public virtual ICollection<Admin> Admins { get; set; } = new HashSet<Admin>();

    }
}
