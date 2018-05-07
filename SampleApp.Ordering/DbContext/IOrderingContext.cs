namespace SampleApp.Ordering.DbContext
{
    using SampleApp.Ordering.Domains;

    public interface IOrderingContext
    {
        System.Data.Entity.DbSet<Order> Orders { get; set; }
    }
}
