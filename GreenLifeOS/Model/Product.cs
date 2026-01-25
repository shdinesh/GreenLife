using GreenLifeOS.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Code { get; set; }

        [Required, MaxLength(200)]
        public string Description { get; set; }

        [Required, Column("selling_price")]
        public double SellingPrice { get; set; }

        // Foreign Key
        [Column("category")]
        public int? CategoryId { get; set; }

        // Navigation property (Many-to-One)
        [ForeignKey(nameof(CategoryId))]
        public virtual ProductCategory Category { get; set; }

        public virtual ProductAvailableStock AvailableStock { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }


        public override string ToString()
        {
            return Name ?? base.ToString();
        }
    }
}
