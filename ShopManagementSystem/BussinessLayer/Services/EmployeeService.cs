using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeesRepository _employeeRepository;

        public EmployeeService(IEmployeesRepository employeesRepository)
        {
            _employeeRepository = employeesRepository;
        }

        public DataTable GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }
    }
}
