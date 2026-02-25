using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class CustomerDashboardRepository : ICustomerDashboardRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public CustomerDashboardRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public CustomerDashboardRepository() : this(new GreenLifeDBContext())
        {
        }

        public CustomerDashboardVo GenerateCustomerboardStats(int customerId)
        {
            return new CustomerDashboardVo
            {
                NumberOfOrdersPlaced = this.GetNumberOfOrdersPlaced(customerId),
                NumberOfOrdersPlacedToday = this.GetTodayOrdersCount(customerId),
                TotalPendingOrders = this.GetTotalOrdersByStatus(customerId, OrderStatus.PENDING.ToString()),
                TotalShippedOrders = this.GetTotalOrdersByStatus(customerId, OrderStatus.SHIPPED.ToString()),
                TotalDeliveredOrders = this.GetTotalOrdersByStatus(customerId, OrderStatus.DELIVERED.ToString()),
            };
        }

        private long GetNumberOfOrdersPlaced(int customerId)
        {
            const string sql = @"
                    SELECT COUNT(o.id)
                    FROM `order` o
                    WHERE o.customer_id = @p0;
                ";

            return dbContext.Database
                            .SqlQuery<long>(sql, customerId)
                            .FirstOrDefault();
        }

        private long GetTotalOrdersByStatus(int customerId, string status)
        {
            const string sql = @"
                    SELECT COUNT(o.id)
                    FROM `order` o
                    WHERE o.customer_id = @p0
                      AND o.status = @p1;
                ";

            return dbContext.Database
                            .SqlQuery<long>(sql, customerId, status)
                            .FirstOrDefault();
        }

        private long GetTodayOrdersCount(int customerId)
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            const string sql = @"
                        SELECT COUNT(o.id)
                        FROM `order` o
                        WHERE o.customer_id = @p0
                          AND o.date >= @p1
                          AND o.date <  @p2;
    ";

            return dbContext.Database
                            .SqlQuery<long>(sql, customerId, today, tomorrow)
                            .FirstOrDefault();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing)
            {
                this.dbContext?.Dispose();
            }
            disposed = true;
        }


    }


}
