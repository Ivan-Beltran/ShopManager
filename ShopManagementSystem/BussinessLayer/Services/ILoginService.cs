using CommonLayer.Entities;

namespace BussinessLayer.Services
{
    public interface ILoginService
    {
        Task<EmployeeSesion> GetSessionAsync(EmployeesInput employees);
    }
}