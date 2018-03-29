using SampleApp.Ordering.Domains.Order;
using SampleApp.Ordering.Infrastructure.Repositories;

namespace SampleApp.Ordering.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        int Commit();

        IRepository<Order> OrderRepository { get; }
    }
}
