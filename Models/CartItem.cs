namespace SneakerShop.Models
{
    public class CartItem
    {
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
        public string Size { get; set; } = string.Empty;
    }
}