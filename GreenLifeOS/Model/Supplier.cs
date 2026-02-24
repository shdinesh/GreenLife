using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("supplier")]
    public class Supplier
    {
        [Column("id")]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Name { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }

        [Required, MaxLength(150)]
        public string Email { get; set; }

        [Required, MaxLength(16)]
        public string Phone { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }

    }
}
