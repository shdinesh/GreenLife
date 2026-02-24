using System;

namespace GreenLifeOS
{
    public class SalesReportVo
    {

        public DateTime OrderDate { get; set; }

        public int NumberOfOrders { get; set; }

        public int NumberOfProducts { get; set; }

        public string TotalSalesAmount { get; set; }

        public string FormattedOrderDate
        {
            get
            {
                return OrderDate.ToString("yyyy-MM-dd");
            }
        }


    }
}
