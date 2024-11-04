using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services
{
    public interface IEmployeeService
    {
        DataTable GetEmployees();

        DataTable GetRoles();

        void AddEmployee(Employees employeeSesion);
    }

}