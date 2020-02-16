namespace Cart.Core
{
    public class OrderLine
    {
        public string Description { get; set; }
        public int Units { get; set; }
        public decimal Price { get; set; }
    }
}
