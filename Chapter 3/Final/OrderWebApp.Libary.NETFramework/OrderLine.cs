namespace OrderWebApp.Library
{
    public class OrderLine
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
