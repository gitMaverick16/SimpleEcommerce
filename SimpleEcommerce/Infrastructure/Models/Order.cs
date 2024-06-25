namespace SimpleEcommerce.Infrastructure.Models
{
    public class Order : BaseEntity
    {
        public DateTime BillingDate { get; set; }
        public Discount Discount { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public int PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
