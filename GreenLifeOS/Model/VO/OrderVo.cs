namespace GreenLifeOS
{
    public class OrderVo
    {

        public int OrderId { get; set; }

        public string OrderDate { get; set; }
        public string LastUpdated { get; set; }

        public string Customer { get; set; }

        public double? Amount { get; set; }
        public string Status{ get; set; }
        public string OrderNumber{ get; set; }

    }
}
