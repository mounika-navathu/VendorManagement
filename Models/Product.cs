namespace VendorManagement.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
