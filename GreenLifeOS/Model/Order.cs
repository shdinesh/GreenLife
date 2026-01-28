using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("order")]
    public class Order
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public double Amount { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("order_number")]
        public string OrderNumber { get; set; }

        [Column("last_updated")]
        public DateTime? LastUpdated { get; set; }

        // Foreign Key
        [Column("customer_id")]
        public int? CustomerId { get; set; }

        // Navigation property (Many-to-One)
        [ForeignKey(nameof(CustomerId))]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }


    }
}
