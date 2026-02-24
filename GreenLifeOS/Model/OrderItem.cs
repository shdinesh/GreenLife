using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("order_item")]
    public class OrderItem
    {
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("order_id")]
        public int OrderId { get; set; }

        [Required]
        [Column("product_id")]
        public int? ProductId { get; set; }

        [Required]
        [Column("qty")]
        public int OrderQty { get; set; }

        [Required]
        [Column("selling_price")]
        public double SellingPrice { get; set; }

        [Column("discount")]
        public double? Discount { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(OrderId))]
        public virtual Order Order { get; set; }

    }
}
