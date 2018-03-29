using SampleApp.Ordering.Domains.Order;
using System.Data.Entity;

namespace SampleApp.Ordering.DbContext
{
    public interface IOrderingContext
    {
        DbSet<Order> Orders { get; set; }
    }
}
