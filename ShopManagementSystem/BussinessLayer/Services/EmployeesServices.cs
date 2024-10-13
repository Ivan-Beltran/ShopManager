using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using CommonLayer.Entities;

namespace BussinessLayer.Services
{
    public class EmployeesServices
    {
        private EmployeesRepository _employeesRepository;

        public EmployeesServices()
        {
            _employeesRepository = new EmployeesRepository();
        }

        public bool FindEmployee(Employees employees)
        {
           return  _employeesRepository.FindEmployee(employees);
        }
    }
}
