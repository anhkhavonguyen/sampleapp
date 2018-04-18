namespace SampleApp.Ordering.DbContext
{
    using SampleApp.Ordering.Domains;
    using System.Data.Entity;

    public partial class OrderingContext : DbContext, IOrderingContext
    {
        public OrderingContext() : base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }

        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
