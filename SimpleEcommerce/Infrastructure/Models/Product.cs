namespace SimpleEcommerce.Infrastructure.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public double Weight { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public int WeightMeasurementId { get; set; }
        public UnitMeasurement UnitMeasurement { get; set; }
    }
}
