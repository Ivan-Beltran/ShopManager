using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services.ServicesForSuppliers
{
    public interface ISuppliersServices
    {
        void AddSupplier(Suppliers supplier);
        void DeleteSupplier(int supplierId);
        void EditSupplier(Suppliers supplier);
        DataTable GetAllSuppliers();
    }
}