using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
   public class Products
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Quantity { get; set; }
        public string PurchaseDate { get; set; }
    }
}
