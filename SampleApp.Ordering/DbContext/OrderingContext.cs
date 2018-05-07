namespace SampleApp.Ordering.DbContext
{
    using SampleApp.Ordering.Domains;

    public partial class OrderingContext : System.Data.Entity.DbContext, IOrderingContext
    {
        public OrderingContext() : base("data source=.;initial catalog=SimpleApp;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {

        }

        public virtual System.Data.Entity.DbSet<Order> Orders { get; set; }


        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
