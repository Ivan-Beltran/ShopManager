using CommonLayer.Entities;
using Dapper;
using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.EmployeesRepo
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
            DataTable rolesTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = "SELECT RoleId,RoleType AS 'Cargos' FROM Roles";

                using (var reader = connection.ExecuteReader(query))
                {
                    rolesTable.Load(reader);
                }
            }

            return rolesTable;
        }

        public void AddEmployee(Employees employeeAdded)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"INSERT INTO Employees
                               VALUES(@Names,@LastNames,@UserEmployee,@PasswordEmployee,@DUI,@Email,@RoleId)";

                connection.Query<Employees>(query,
                    new
                    {
                        employeeAdded.Names,
                        employeeAdded.LastNames,
                        employeeAdded.UserEmployee,
                        employeeAdded.PasswordEmployee,
                        employeeAdded.DUI,
                        employeeAdded.Email,
                        employeeAdded.RoleId
                    });
            }
        }

        public void EditEmployee(Employees employeeEdited)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"UPDATE Employees
                                 SET Names=@Names,
                                     LastNames=@LastNames,
                                     UserEmployee=@UserEmployee,
                                     PasswordEmployee=@PasswordEmployee,
                                     DUI=@DUI,
                                     Email=@Email,
                                     RoleId=@RoleId
                                     Where EmployeeId=@EmployeeId";

                connection.Query<Employees>(query,
                    new
                    {
                        employeeEdited.EmployeeId,
                        employeeEdited.Names,
                        employeeEdited.LastNames,
                        employeeEdited.UserEmployee,
                        employeeEdited.PasswordEmployee,
                        employeeEdited.DUI,
                        employeeEdited.Email,
                        employeeEdited.RoleId
                    });
            }
        }

        public void DeleteEmployee(int EmployeeId)
        {
            using (var connection = _dbConnection.GetConnection())
            {
                string query = "DELETE FROM Employees WHERE EmployeeId = @EmployeeId";

                connection.Query<Employees>(query, new { EmployeeId });
            }
        }

        public DataTable SearchEmployee(string search)
        {
            DataTable searchEmployeeTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                // Corregir la sintaxis de la consulta
                string query = @"SELECT
            E.EmployeeId AS ID,
            E.Names AS Nombres,
            E.LastNames AS Apellidos,
            E.UserEmployee AS Usuario,
            E.PasswordEmployee AS Contraseña,
            E.DUI,
            E.Email,
            R.RoleType AS Cargo
            FROM Employees AS E
            INNER JOIN Roles AS R ON E.RoleId = R.RoleId
            WHERE E.Names LIKE @search 
            OR E.LastNames LIKE @search
            OR E.UserEmployee LIKE @search"; // Agregar la búsqueda en varios campos

                // Usar ExecuteReader con el parámetro correctamente
                using (var reader = connection.ExecuteReader(query, new { search = "%" + search + "%" }))
                {
                    searchEmployeeTable.Load(reader); // Cargar los resultados en el DataTable
                }
            }

            return searchEmployeeTable;
        }



    }
}
