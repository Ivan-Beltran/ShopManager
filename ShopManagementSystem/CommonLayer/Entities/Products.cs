using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
   public class Products
    {
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Version {  get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
        public int ProductAmount { get; set; }

        public int ProdutTypeId {  get; set; }
    }
}
