using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.dbConnect;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;

namespace DataAccessLayer.Repositories
{
    public class LoginRepository
    {
        private SqlConnect _dbconnect;

        public LoginRepository()
        {
            _dbconnect = new SqlConnect();
        }
        
        //metoedo para crear un objeto con los atributos del empleado
        public EmployeeSesion GetEmployeSesion(EmployeesInput employees)
        {
            EmployeeSesion employeeSesion= null;

            using (var connection = _dbconnect.GetConnection())
            {
                string query = @"SELECT
                           E.EmployeeId,
                           E.Names,
                           E.LastNames,
                           E.UserEmployee,
                           E.PasswordEmployee,
                           E.DUI,
                           E.Email,
                           E.RoleId
                        FROM Employees AS E
                        INNER JOIN Roles AS R
                        ON E.RoleId = R.RoleId
                        WHERE UserEmployee = @UserEmployee
                        AND PasswordEmployee = @PasswordEmployee";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserEmployee",employees.User);
                    command.Parameters.AddWithValue("@PasswordEmployee",employees.Password);
                    command.CommandTimeout = 10;
                    connection.Open();

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                           
                            employeeSesion = new EmployeeSesion
                            {
                                EmployeeId = reader.GetInt32(reader.GetOrdinal("EmployeeId")),
                                EmployeeNames = reader.GetString(reader.GetOrdinal("Names")),
                                EmployeeLastNames = reader.GetString(reader.GetOrdinal("LastNames")),
                                EmployeeUser = reader.GetString(reader.GetOrdinal("UserEmployee")),
                                EmployeePassword= reader.GetString(reader.GetOrdinal("PasswordEmployee")),
                                EmployeeDUI = reader.GetString(reader.GetOrdinal("DUI")),
                                EmployeeEmail = reader.GetString(reader.GetOrdinal("Email")),
                                EmployeeRoleId = reader.GetInt32(reader.GetOrdinal("RoleId"))
                            };
                        }
                    }
                }
            }

            return employeeSesion; 
        }
    }
}
