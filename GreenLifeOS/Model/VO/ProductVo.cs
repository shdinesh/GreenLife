namespace GreenLifeOS
{
    public class ProductVo
    {

        public int Id { get; set; }
        public int LineItemId { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
        public string NameAndCode => Name + " - " + Code;



        public string Description { get; set; }
        public double SellingPrice { get; set; }

        public int CategoryId { get; set; }
        public int PurchaseQuantity { get; set; }

        public double LineItemTotal => (double)(PurchaseQuantity * SellingPrice);
        public double? Discount { get; set; }

        public virtual string Category { get; set; }

        public virtual long AvailableStock { get; set; }

    }
}
