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

                // Ejecutamos la consulta y llenamos el DataTable
                using (var reader = connection.ExecuteReader(query))
                {
                    // Llenamos el DataTable con los resultados
                    employeesTable.Load(reader);
                }
            }

            return employeesTable;
        }
    }
}
