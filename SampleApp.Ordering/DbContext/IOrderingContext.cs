namespace SampleApp.Ordering.DbContext
{
    using SampleApp.Ordering.Domains;
    using System.Data.Entity;

    public interface IOrderingContext
    {
        DbSet<Order> Orders { get; set; }
    }
}
