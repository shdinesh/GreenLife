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
                throw new InvalidOperationException("An error occurred while retrieving Sales Report. Please try again.", ex);
            }
        }


        private ValidationResult ValidateAdmin(Admin Admin)
        {
            var result = new ValidationResult { IsValid = true };

            return result;
        }

       
    }


}
