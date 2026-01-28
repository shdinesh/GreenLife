using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface IAdminService
    {
        Admin AddNewAdmin(Admin admin);
        List<Admin> GetAllAdmins();
        Admin GetAdminById(int id);
        Admin UpdateAdmin(Admin admin);
        bool DeleteAdmin(int id);

    }
}
