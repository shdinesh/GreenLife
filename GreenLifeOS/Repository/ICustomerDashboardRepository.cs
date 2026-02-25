using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface ICustomerDashboardRepository
    {
      
        CustomerDashboardVo GenerateCustomerboardStats(int customerId);


    }
}
