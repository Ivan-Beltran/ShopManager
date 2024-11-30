using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories.ClientsRepo;

namespace BussinessLayer.Services.ServicesForClients
{
    public class ClientsServices : IClientsServices
    {
        IClientsRepository _clientsRepository;

        public ClientsServices(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        public DataTable GetClients()
        {
            return _clientsRepository.GetClients();
        }

    }
}
