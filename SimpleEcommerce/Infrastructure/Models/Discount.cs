namespace SimpleEcommerce.Infrastructure.Models
{
    public class Discount : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
