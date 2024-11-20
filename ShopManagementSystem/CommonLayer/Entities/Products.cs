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
        public int ProductTypeId {  get; set; }
        public string ProductBrand { get; set; }
        public string ProductModel { get; set; }
        public string ProductVersion {  get; set; }
        public string ProductColor { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }

        public int Availability {  get; set; }

        public string ImageUrl {  get; set; }

    }
}
