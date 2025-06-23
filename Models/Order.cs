using System;

namespace VendorManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public DateTime OrderDate { get; set; }
        public int QuantityOrdered { get; set; }
    }
}
