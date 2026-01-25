using System.Collections.Generic;

namespace GreenLifeOS.Service
{
    internal interface ISupplierService
    {
        Supplier AddNewSupplier(Supplier supplier);
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        Supplier UpdateSupplier(Supplier student);
        bool DeleteSupplier(int id);

    }
}
