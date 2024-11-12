using CommonLayer.Entities;


namespace BussinessLayer.Services.ServicesForLogin
{
    public interface ILoginService
    {
        Task<Employees> GetSessionAsync(Employees employeesInput);
    }
}