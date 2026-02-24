using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("product_rating_and_review")]
    public class ProductRatingAndReview
    {
        [Column("id")]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [Column("customer_id")]
        public int CustomerId { get; set; }

        [Required]
        [Column("product_id")]
        public int ProductId { get; set; }

        [Required]
        [Column("rating")]
        public int Rating { get; set; }

        [MaxLength(200)]
        [Column("review")]
        public string Review { get; set; }


        // Navigation property (Many-to-One)
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }

        // Navigation property (Many-to-One)
        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }



    }
}
