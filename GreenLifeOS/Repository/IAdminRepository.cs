using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface IAdminRepository
    {
        Admin AddNewAdmin(Admin admin);
        Admin UpdateAdmin(Admin admin);
        List<Admin> GetAllAdmins();
        Admin GetAdminById(int id);
        bool DeleteAdmin(int id);

    }
}
