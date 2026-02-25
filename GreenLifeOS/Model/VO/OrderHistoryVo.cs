using System;

namespace GreenLifeOS
{
    public class OrderHistoryVo
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }  
        public decimal OrderAmount { get; set; }
        public string OrderStatus { get; set; }
        public long NumberOfProducts { get; set; }

        public string FormattedOrderDate
        {
            get
            {
                return OrderDate.ToString("yyyy-MM-dd");
            }
        }


    }
}
