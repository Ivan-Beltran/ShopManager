using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class BuyingOrders
    {
        public int BuysId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice {  get; set; }
        public decimal Total { get; set; }
        public DateTime Date {  get; set; }
        public string Status {  get; set; }
        public int SuppliersId {  get; set; }
        public int ProductTypeId { get; set; }
        public int ProductId { get; set; }
    }
}
