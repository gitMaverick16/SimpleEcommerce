namespace SimpleEcommerce.Infrastructure.Models
{
    public class OrderDetail : BaseEntity
    {
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
