using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EmployeeRepository : IEmployeesRepository
    {
        private readonly ISqlConnect _dbConnection;

        public EmployeeRepository(ISqlConnect dbconnection)
        {
            _dbConnection = dbconnection;
        }

        public DataTable GetEmployees()
        {
            DataTable employeesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT
                       E.EmployeeId AS ID,
                       E.Names AS Nombres,
                       E.LastNames AS Apellidos,
                       E.UserEmployee AS Usuario,
                       E.PasswordEmployee AS Contraseña,
                       E.DUI,
                       E.Email,
                       R.RoleType  AS Cargo
                    FROM Employees AS E
                    INNER JOIN Roles AS R
                    ON E.RoleId = R.RoleId";

                
                using (var reader = connection.ExecuteReader(query))
                {
                    
                    employeesTable.Load(reader);
                }
            }

            return employeesTable;
        }

        public DataTable GetRoles()
        {
            DataTable rolesTable= new DataTable();
            
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT RoleId,RoleType AS 'Cargos' FROM Roles";

                using(var reader = connection.ExecuteReader(query))
                {
                    rolesTable.Load(reader);
                }
            }

            return rolesTable;
        }

        public void AddEmployee(Employees employeeSesion)
        {
            using(var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Employees
                               VALUES(@Names,@LastNames,@UserEmployee,@PasswordEmployee,@DUI,@Email,@RoleId)";

                connection.Query<Employees>(query,
                    new
                    {
                        employeeSesion.Names,
                        employeeSesion.LastNames,
                        employeeSesion.UserEmployee,
                        employeeSesion.PasswordEmployee,
                        employeeSesion.DUI,
                        employeeSesion.Email,
                        employeeSesion.RoleId
                    });
            }
        }
    }
}
