using CommonLayer.Entities;


namespace BussinessLayer.Services
{
    public interface ILoginService
    {
        Task<Employees> GetSessionAsync(Employees employeesInput);
    }
}