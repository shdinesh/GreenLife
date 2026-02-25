using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        [Required, MaxLength(10)]
        public string Title { get; set; }

        [Column("first_name")]
        [Required, MaxLength(150)]
        public string FirstName { get; set; }

        [Column("last_name")]
        [Required, MaxLength(150)]
        public string LastName { get; set; }

        [Column("phone_number")]
        [Required, MaxLength(16)]
        public string PhoneNumber { get; set; }

        [Required, MaxLength(200)]
        public string Address { get; set; }

        [MaxLength(150)]
        public string Email { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<ProductRatingAndReview> RatingAndReviews { get; set; }


    }
}
