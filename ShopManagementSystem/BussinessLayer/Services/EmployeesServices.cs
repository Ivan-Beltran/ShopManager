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
    public class EmployeesServices : IEmployeeService
    {
        private IEmployeesRepository _employeeRepository;

        public EmployeesServices(IEmployeesRepository employeesRepository)
        {
            _employeeRepository = employeesRepository;
        }

        public DataTable GetEmployees()
        {
            return _employeeRepository.GetEmployees();
        }

        public DataTable GetRoles()
        {
            return _employeeRepository.GetRoles();
        }

        public void AddEmployee(Employees employeeAdded)
        {
            _employeeRepository.AddEmployee(employeeAdded);
        }

        public void EditEmployee(Employees employeeEdited)
        {
            _employeeRepository.EditEmployee(employeeEdited);
        }
    }
}
