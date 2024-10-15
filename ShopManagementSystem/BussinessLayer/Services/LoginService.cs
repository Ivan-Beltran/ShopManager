using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using CommonLayer.Entities;

namespace BussinessLayer.Services
{
    public class LoginService
    {
        private LoginRepository _loginRepository;

        public LoginService()
        {
            _loginRepository = new LoginRepository();
        }

        

        public EmployeeSesion GetEmployeeSesion(EmployeesInput employees)
        {
            return _loginRepository.GetEmployeSesion(employees);
        }

       
    }
}
