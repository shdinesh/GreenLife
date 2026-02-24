using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IReportsService
    {

        List<SalesReportVo> GenerateSalesReport(string dateFrom, string dateTo);


    }
}
