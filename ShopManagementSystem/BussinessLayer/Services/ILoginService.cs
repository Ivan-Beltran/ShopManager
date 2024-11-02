using CommonLayer.Entities;
using CommonLayer.InputEntities;

namespace BussinessLayer.Services
{
    public interface ILoginService
    {
        Task<EmployeeSesion> GetSessionAsync(EmployeesInput employees);
    }
}