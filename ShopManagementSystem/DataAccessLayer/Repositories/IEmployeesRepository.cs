using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public interface IEmployeesRepository
    {
        DataTable GetEmployees();

        DataTable GetRoles();

        void AddEmployee(Employees employeeAdded);

        void EditEmployee(Employees employeeEdited);

        void DeleteEmployee(int Id);

        DataTable SearchEmployee(string search);
    }
}
