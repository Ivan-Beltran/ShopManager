using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services
{
    public interface IEmployeeService
    {
        DataTable GetEmployees();

        DataTable GetRoles();

        void AddEmployee(Employees employeeAdded);

        void EditEmployee(Employees EmployeeEdited);

        void DeleteEmployee(int Id);

        DataTable SearchEmployee(string search);
    }

}