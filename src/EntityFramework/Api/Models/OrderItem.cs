namespace Api.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }

        public int OrderId { get; set; }
    }
}