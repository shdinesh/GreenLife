using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS.Model
{
    [Table("product_available_stock")]

    public class ProductAvailableStock
    {

        [Column("id")]
        public int Id { get; set; }

        [Key]
        [ForeignKey(nameof(Product))]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        [Column("quantity")]
        public long Quantity { get; set; }

        [Required]
        [Column("last_updated")]
        public DateTime LastUpdated { get; set; }

        public virtual Product Product { get; set; }

    }
}
