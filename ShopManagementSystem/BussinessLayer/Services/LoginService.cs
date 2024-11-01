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


        public async Task<EmployeeSesion> GetSessionAsync(EmployeesInput employees)
        {
            return await _loginRepository.GetSessionAsync(employees);
        }
        


    }
}
