using GreenLifeOS.Repository;
using System;
using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal class ReportsService : IReportsService
    {
        private readonly IReportsRepository reportsRepository;

        public ReportsService(IReportsRepository reportsRepository)
        {
            this.reportsRepository = reportsRepository ?? throw new ArgumentNullException(nameof(reportsRepository));
        }

        public ReportsService() : this(new ReportsRepository())
        {
        }


        public List<SalesReportVo> GenerateSalesReport(string dateFrom, string dateTo)
        {
            try
            {
                var salesReport = reportsRepository.GenerateSalesReport(dateFrom, dateTo);

                return salesReport ?? new List<SalesReportVo>();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while generating Sales Report. Please try again.", ex);
            }
        }

        public List<OrderHistoryVo> GenerateOrderHistoryReport(string customerName, string dateFrom, string dateTo, string orderStatus)
        {
            try
            {
                var salesReport = reportsRepository.GenerateOrderHistoryReport(customerName, dateFrom, dateTo, orderStatus);

                return salesReport ?? new List<OrderHistoryVo>();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("An error occurred while generating Order History Report. Please try again.", ex);
            }
        }


        private ValidationResult ValidateAdmin(Admin Admin)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }

       
    }


}
