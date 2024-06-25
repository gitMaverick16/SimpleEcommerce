namespace SimpleEcommerce.Infrastructure.Models
{
    public class PaymentMethod  : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
