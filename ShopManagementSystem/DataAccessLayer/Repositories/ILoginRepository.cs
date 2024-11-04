using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public interface ILoginRepository
    {
         Task<Employees> GetSessionAsync(Employees employeesInput);
        
    }
}
