using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.dbConnect;
using CommonLayer.Entities;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Dapper;


namespace DataAccessLayer.Repositories.LoginRepo
{
    public class LoginRepository : ILoginRepository
    {
        private ISqlConnect _dbConnection;

        public LoginRepository(ISqlConnect dbconnection)
        {
            _dbConnection = dbconnection;
        }

        //metoedo para crear un objeto con los atributos del empleado usando dapper

        public async Task<Employees> GetSessionAsync(Employees employeesInput)
        {
            using (var connection = _dbConnection.GetConnection())
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
                        WHERE E.UserEmployee = @UserEmployee";

                return await connection.QueryFirstOrDefaultAsync<Employees>(query, new { employeesInput.UserEmployee });
            }
        }
    }
}
