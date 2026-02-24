using System;
using System.Collections.Generic;
using System.Linq;

namespace GreenLifeOS.Repository
{
    public class ReportsRepository : IReportsRepository
    {
        private readonly GreenLifeDBContext dbContext;
        private bool disposed = false;

        public ReportsRepository(GreenLifeDBContext dbContext)
        {
            this.dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public ReportsRepository() : this(new GreenLifeDBContext())
        {
        }

        public List<SalesReportVo> GenerateSalesReport(string dateFrom, string dateTo)
        {

            // IMPORTANT: use backticks because `order` is reserved
            // Also: total_amount is calculated correctly (no double counting)
            const string sql = @"
                            SELECT 
                                daily.order_date      AS OrderDate,
                                COUNT(*)              AS NumberOfOrders,
                                SUM(daily.total_items) AS NumberOfProducts,
                                FORMAT(SUM(daily.amount), 2)     AS TotalSalesAmount
                            FROM
                            (
                                SELECT 
                                    DATE(o.date) AS order_date,
                                    o.id,
                                    o.amount,
                                    IFNULL(SUM(oi.qty), 0) AS total_items
                                FROM `order` o
                                LEFT JOIN order_item oi ON oi.order_id = o.id
                                WHERE o.date >= @p0 AND o.date < @p1
                                GROUP BY o.id
                            ) daily
                            GROUP BY daily.order_date
                            ORDER BY daily.order_date;
                            ";

            // EF6: Database.SqlQuery<T>() maps column aliases to SalesReportVo properties
            return dbContext.Database
                            .SqlQuery<SalesReportVo>(sql, dateFrom, dateTo)
                            .ToList();
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
