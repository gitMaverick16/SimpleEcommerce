namespace SimpleEcommerce.Infrastructure.Models
{
    public class UnitMeasurement : BaseEntity
    {
        public string Name{ get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
