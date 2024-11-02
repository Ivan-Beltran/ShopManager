using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services
{
    public interface IEmployeeService
    {
        DataTable GetEmployees();
    }
}