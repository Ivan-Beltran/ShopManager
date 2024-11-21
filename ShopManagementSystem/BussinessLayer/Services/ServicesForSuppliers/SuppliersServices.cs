using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.SuppliersRepo;
using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services.ServicesForSuppliers
{
    public class SuppliersServices : ISuppliersServices
    {
        private ISuppliersRepository _suppliersRepository;

        public SuppliersServices(ISuppliersRepository suppliersRepository)
        {
            _suppliersRepository = suppliersRepository;
        }

        public DataTable GetAllSuppliers()
        {
            return _suppliersRepository.GetAllSuppliers();
        }

        public void AddSupplier(Suppliers supplier)
        {
            _suppliersRepository.AddSupplier(supplier);
        }

        public void EditSupplier(Suppliers supplier)
        {
            _suppliersRepository.EditSupplier(supplier);
        }

        public void DeleteSupplier(int supplierId)
        {
            _suppliersRepository.DeleteSupplier(supplierId);
        }
    }
}
