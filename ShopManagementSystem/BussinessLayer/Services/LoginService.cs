using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using CommonLayer.Entities;


namespace BussinessLayer.Services
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
