using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class PurchaseOrders
    {
        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        public string Details {  get; set; }
        public decimal Total { get; set; }
        public DateTime PurchaseDate {  get; set; }
        public bool PurchaseState {  get; set; }
    }
}
