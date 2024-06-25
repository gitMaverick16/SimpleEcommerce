using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleEcommerce.Infrastructure.Models
{
    public class EcommerceContext : IdentityDbContext<User> 
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options) : base(options) { }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UnitMeasurement> UnitMeasurements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Discount>(d =>
            {
                d.HasKey(d => d.Id);
            });

            modelBuilder.Entity<Order>(o =>
            {
                o.HasKey(o => o.Id);
            });

            modelBuilder.Entity<OrderDetail>(od =>
            {
                od.HasKey(od => od.Id);
            });

            modelBuilder.Entity<PaymentMethod>(pm =>
            {
                pm.HasKey(pm => pm.Id);
            });

            modelBuilder.Entity<Product>(p =>
            {
                p.HasKey(p => p.Id);
            });

            modelBuilder.Entity<UnitMeasurement>(um =>
            {
                um.HasKey(um => um.Id);
            });
        }
    }

}
