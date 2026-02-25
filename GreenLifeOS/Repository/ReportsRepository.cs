using System;
using System.Collections.Generic;
using System.Globalization;
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

            return dbContext.Database
                            .SqlQuery<SalesReportVo>(sql, dateFrom, dateTo)
                            .ToList();
        }

        public List<OrderHistoryVo> GenerateOrderHistoryReport(string customerName, string dateFrom, string dateTo, string orderStatus)
        {
            const string sql = @"
                            SELECT
                                o.id AS OrderId,
                                o.order_number AS OrderNumber,
                                CONCAT(c.first_name, ' ', c.last_name) AS CustomerName,
                                DATE(o.date) AS OrderDate,
                                CAST(ROUND(o.amount, 2) AS DECIMAL(12,2)) AS OrderAmount,
                                o.status AS OrderStatus,
                                IFNULL(SUM(oi.qty), 0) AS NumberOfProducts
                            FROM `order` o
                            JOIN customer c         ON c.id = o.customer_id
                            LEFT JOIN order_item oi ON oi.order_id = o.id
                            WHERE
                                o.date >= @p0
                                AND o.date <  @p1
                                AND (@p2 IS NULL OR @p2 = '' OR CONCAT(c.first_name, ' ', c.last_name) LIKE CONCAT('%', @p2, '%'))
                                AND (@p3 IS NULL OR @p3 = '' OR o.status = @p3)
                            GROUP BY
                                o.id, o.order_number, c.first_name, c.last_name, DATE(o.date), o.amount, o.status
                            ORDER BY o.date DESC;
                            ";

            // Pass null/empty safely
            customerName = string.IsNullOrWhiteSpace(customerName) || customerName.Equals("All", StringComparison.OrdinalIgnoreCase)
                    ? null : customerName.Trim();
            orderStatus = string.IsNullOrWhiteSpace(orderStatus) || orderStatus.Equals("All", StringComparison.OrdinalIgnoreCase)
                ? null : orderStatus.Trim();

            return dbContext.Database
                .SqlQuery<OrderHistoryVo>(sql, dateFrom, dateTo, customerName, orderStatus)
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
