using CommonLayer.Entities;
using System.Data;

namespace DataAccessLayer.Repositories.SuppliersRepo
{
    public interface ISuppliersRepository
    {
        void AddSupplier(Suppliers supliers);
        void DeleteSupplier(int supplierId);
        void EditSupplier(Suppliers supplier);
        DataTable GetAllSuppliers();
    }
}