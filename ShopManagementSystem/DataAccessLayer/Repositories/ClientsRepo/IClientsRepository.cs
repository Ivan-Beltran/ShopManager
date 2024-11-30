using System.Data;

namespace DataAccessLayer.Repositories.ClientsRepo
{
    public interface IClientsRepository
    {
        DataTable GetClients();
    }
}