using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Clients
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientLastName {  get; set; }
        public string ClientEmail{ get; set; }
        public string ClientDUI {  get; set; }
        public string ClientPhone { get; set; }

    }
}
