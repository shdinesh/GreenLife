using System;

namespace GreenLifeOS
{
    public class CustomerDashboardVo
    {
        public long NumberOfOrdersPlaced { get; set; }
        public long NumberOfOrdersPlacedToday { get; set; }
        public long TotalPendingOrders { get; set; }
        public long TotalShippedOrders { get; set; }
        public long TotalDeliveredOrders { get; set; }

    }
}
