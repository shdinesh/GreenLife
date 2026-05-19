using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GreenLifeOS.Validation.Request
{
    internal class ProductRegistrationRequest
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public string Description { get; set; }

        public string SellingPrice { get; set; }

        public string Discount { get; set; }

        public string CategoryId { get; set; }
        public string Photo { get; set; }
    }

}
