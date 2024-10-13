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
    public class EmployeesRepository
    {
        private SqlConnect _dbconnect;

        public EmployeesRepository()
        {
            _dbconnect = new SqlConnect();
        }

        public bool FindEmployee(Employees employee)
        {
            bool foundEmployee=false;

            using(var connection = _dbconnect.GetConnection())
            {
                string query = @"select
	                              E.EmployeeId,
	                              E.UserEmployee,
                                  E.PasswordEmployee,
	                              E.RoleId,
	                              R.RoleType
                                FROM Employees AS E
                                INNER JOIN Roles R ON E.RoleId=R.RoleId 
                                WHERE E.UserEmployee=@UserEmployee
                                AND   E.PasswordEmployee=@PasswordEmployee";

                using (var command= new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserEmployee", employee.User);
                    command.Parameters.AddWithValue("@PasswordEmployee", employee.Password);
                    connection.Open();
                    using(var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundEmployee = true;
                        }
                    }
                }
            }
            return foundEmployee;
        }
    }
}
