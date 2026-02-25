using System;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class AdminDashboardRepository : IAdminDashboardRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public AdminDashboardRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public AdminDashboardRepository() : this(new GreenLifeDBContext())
        {
        }

        public AdminDashboardVo GenerateAdminDashboardStats()
        {
            return
               new AdminDashboardVo
               {
                   TotalCustomers = this.GetTotalCustomers(),
                   TotalSuppliers = this.GetTotalSuppliers(),
                   TotalProducts = this.GetTotalProducts(),
                   TotalActiveOrders = this.GetTotalActiveOrders(),
                   TotalLowStockProducts = this.GetTotalLowStockProducts(),
                   TodayOrdersCount = this.GetTodayOrdersCount(),
                   TodaySalesAmount = this.GetTodaySalesAmount()

               };
        }

        private long GetTotalActiveOrders()
        {
            const string sql = @"
                        SELECT COUNT(o.id)
                        FROM `order` o
                        WHERE o.status IN ('PENDING', 'SHIPPED');
                    ";

            return dbContext.Database
                            .SqlQuery<long>(sql)
                            .FirstOrDefault();
        }

        private long GetTotalCustomers()
        {
            const string sql = @"
                        SELECT 
                            COUNT(id) AS TotalCustomers
                        FROM
                            customer;
                    ";

            return dbContext.Database
                            .SqlQuery<long>(sql)
                            .FirstOrDefault();
        }

        private long GetTotalSuppliers()
        {
            const string sql = @"
                        SELECT 
                            COUNT(id) AS TotalSuppliers
                        FROM
                            supplier;
                    ";

            return dbContext.Database
                            .SqlQuery<long>(sql)
                            .FirstOrDefault();
        }

        private long GetTotalProducts()
        {
            const string sql = @"
                        SELECT 
                            COUNT(id) AS TotalProducts
                        FROM
                            product;
                    ";

            return dbContext.Database
                            .SqlQuery<long>(sql)
                            .FirstOrDefault();
        }
        private long GetTodayOrdersCount()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            const string sql = @"
                        SELECT COUNT(o.id)
                        FROM `order` o
                        WHERE o.date >= @p0
                          AND o.date <  @p1;
    ";

            return dbContext.Database
                            .SqlQuery<long>(sql, today, tomorrow)
                            .FirstOrDefault();
        }

        private decimal GetTodaySalesAmount()
        {
            DateTime today = DateTime.Today;
            DateTime tomorrow = today.AddDays(1);

            const string sql = @"
                    SELECT COALESCE(SUM(o.amount), 0)
                    FROM `order` o
                    WHERE o.date >= @p0
                      AND o.date <  @p1;
    ";

            return dbContext.Database
                            .SqlQuery<decimal>(sql, today, tomorrow)
                            .FirstOrDefault();
        }

        private long GetTotalLowStockProducts()
        {
            const string sql = @"
                SELECT COUNT(p.id)
                FROM product p
                LEFT JOIN product_available_stock ps 
                       ON p.id = ps.product_id
                WHERE ps.quantity IS NULL 
                   OR ps.quantity < 10;
    ";

            return dbContext.Database
                            .SqlQuery<long>(sql)
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
