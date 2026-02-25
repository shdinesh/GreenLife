using System;

namespace GreenLifeOS
{
    public class AdminDashboardVo
    {
        public long TotalCustomers { get; set; }
        public long TotalSuppliers { get; set; }
        public long TotalProducts { get; set; }
        public long TotalActiveOrders { get; set; }
        public long TotalLowStockProducts { get; set; }
        public long TodayOrdersCount { get; set; }
        public Decimal TodaySalesAmount { get; set; }


    }
}
