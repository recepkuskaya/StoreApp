namespace StoreApp.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String? ProductName { get; set; } = String.Empty;
        public int MyProperty { get; set; }
        public decimal Price { get; set; }
    }
    
}