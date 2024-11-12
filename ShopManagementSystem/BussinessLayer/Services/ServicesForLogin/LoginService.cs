using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using DataAccessLayer.Repositories.LoginRepo;


namespace BussinessLayer.Services.ServicesForLogin
{
    public class LoginService : ILoginService
    {
        private ILoginRepository _loginRepository;

        public LoginService(ILoginRepository loginRepository)
        {
            _loginRepository = loginRepository;
        }


        public async Task<Employees> GetSessionAsync(Employees employeesInput)
        {
            return await _loginRepository.GetSessionAsync(employeesInput);
        }



    }
}
