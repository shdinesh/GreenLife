using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("product_inventory")]
    public class Stock
    {

        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        [Column("supplier_id")]
        public int SupplierId { get; set; }

        [Required]
        [Column("quantity")]
        public int StockQty { get; set; }

        [Required]
        [Column("price")]
        public double Price { get; set; }

        [Required]
        [Column("date")]
        public DateTime Date { get; set; }


        // Navigation property (Many-to-One)
        [ForeignKey(nameof(SupplierId))]
        public virtual Supplier Supplier { get; set; }

        // Navigation property (Many-to-One)
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

    }
}
