﻿using CommonLayer.Entities;
using System.Data;

namespace BussinessLayer.Services.ServicesForEmployees
{
    public interface IEmployeeService
    {
        DataTable GetEmployees();

        DataTable GetRoles();

        void AddEmployee(Employees employeeAdded);

        void EditEmployee(Employees EmployeeEdited);

        void DeleteEmployee(int Id);

        DataTable SearchEmployee(string search);
        string GetEmployeePassword(int EmployeeId);
    }

}