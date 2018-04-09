using System;
using SampleApp.Ordering.DbContext;
using SampleApp.Ordering.Infrastructure.Repositories;
using SampleApp.Ordering.Domains;

namespace SampleApp.Ordering.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private OrderingContext _orderingContext = new OrderingContext();
        private Repository<Order> orderRepository;
        public UnitOfWork()
        {
        }

        public IRepository<Order> OrderRepository
        {
            get
            {
                if (orderRepository == null)
                {
                    orderRepository = new Repository<Order>(_orderingContext);
                }
                return orderRepository;
            }
        }

        public int Commit()
        {
            return _orderingContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_orderingContext != null)
                {
                    _orderingContext.Dispose();
                    _orderingContext = null;
                }
            }
        }
    }
}
