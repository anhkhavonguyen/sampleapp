using SampleApp.Business.Domains.Order;
using System.Data.Entity;

namespace SampleApp.Business.DbContext
{
    public interface IOrderingContext
    {
        DbSet<Order> Orders { get; set; }
    }
}
