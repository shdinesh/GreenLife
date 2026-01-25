using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("product_inventory")]
    public class Stock
    {

        [Column("id")]
        public int Id { get; set; }


        // Foreign Key
        [Column("product_id")]
        public int? ProductId { get; set; }

        // Foreign Key
        [Column("supplier")]
        public int? SupplierId { get; set; }


        [Column("quantity")]
        public int StockQty { get; set; }

        [Column("price")]
        public double Price { get; set; }


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
