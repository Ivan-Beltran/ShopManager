using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Sales
    {
        public int SalesId { get; set; }
        public int SaleClientId {  get; set; }

        public decimal TotalAmount {  get; set; }
        public DateTime SaleDate {  get; set; }

    }
}
