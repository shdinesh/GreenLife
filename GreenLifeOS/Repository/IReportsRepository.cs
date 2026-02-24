using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface IReportsRepository
    {
      
        List<SalesReportVo> GenerateSalesReport(string dateFrom, string dateTo);

    }
}
