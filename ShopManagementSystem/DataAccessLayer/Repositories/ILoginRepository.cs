﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;
using CommonLayer.InputEntities;

namespace DataAccessLayer.Repositories
{
    public interface ILoginRepository
    {
         Task<EmployeeSesion> GetSessionAsync(EmployeesInput employeesInput);
        
    }
}