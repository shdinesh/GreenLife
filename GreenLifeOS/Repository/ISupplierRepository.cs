using System.Collections.Generic;

namespace GreenLifeOS.Repository
{
    internal interface ISupplierRepository
    {
        Supplier AddNewSupplier(Supplier supplier);
        Supplier UpdateSupplier(Supplier supplier);
        List<Supplier> GetAllSuppliers();
        Supplier GetSupplierById(int id);
        bool DeleteSupplier(int id);


    }
}
