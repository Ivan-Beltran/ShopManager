using Dapper;
using DataAccessLayer.dbConnect;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.ClientsRepo
{
    public class ClientsRepository : IClientsRepository
    {
        ISqlConnect _dbConnection;

        public ClientsRepository(ISqlConnect dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public DataTable GetClients()
        {
            DataTable clientsTable = new DataTable();

            using (var connection = _dbConnection.GetConnection())
            {
                string query = @"SELECT ClientName AS Nombre,
                                    ClientLastName AS Apellido,
                                    ClientEmail AS Email,
                                    ClientDUI AS DUI,
                                    ClientTelephone AS TELEFONO
                                    FROM Clients";

                using (var reader = connection.ExecuteReader(query))
                {
                    clientsTable.Load(reader);
                }
            }
            return clientsTable;
        }
    }
}
