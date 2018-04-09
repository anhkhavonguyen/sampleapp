using SampleApp.Ordering.Domains;
using SampleApp.Ordering.Message;
using SampleApp.Ordering.Queries.GetOrder;

namespace SampleApp.Ordering.Services
{
    public class OrderService : IOrderService
    {
        private GetOrderQuery _getOrderQuery;
        public OrderService(GetOrderQuery getOrderQuery)
        {
            _getOrderQuery = getOrderQuery;
        }

        public void CreateOrder(AddOrderRequest request)
        {
           
        }

        public Order GetOrder(int id)
        {
            return _getOrderQuery.GetOrder(id);
        }
    }
}
