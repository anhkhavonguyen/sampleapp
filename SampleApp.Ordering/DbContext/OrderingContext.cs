using SampleApp.Ordering.Domains.Order;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SampleApp.Ordering.DbContext
{
    public class OrderingContext : System.Data.Entity.DbContext, IOrderingContext
    {
        public OrderingContext() : base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        private void SetUp(EntityTypeConfiguration<Order> entityTypeConfiguration)
        {

        }
    }
}
