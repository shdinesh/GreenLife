using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface ICustomerDashboardService
    {

        CustomerDashboardVo GenerateCustomerboardStats(int customerId);


    }
}
