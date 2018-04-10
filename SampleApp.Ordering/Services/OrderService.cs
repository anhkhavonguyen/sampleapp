using SampleApp.Business.Ordering.Command.CreateOrderCommand;
using SampleApp.Ordering.Domains;
using SampleApp.Ordering.Message;
using SampleApp.Ordering.Queries.GetOrder;

namespace SampleApp.Ordering.Services
{
    public class OrderService : IOrderService
    {
        private IGetOrderQuery _getOrderQuery;
        private ICreateOrderCommandHandler _createOrderCommandHandler;
        public OrderService(IGetOrderQuery getOrderQuery, ICreateOrderCommandHandler createOrderCommandHandler)
        {
            _getOrderQuery = getOrderQuery;
            _createOrderCommandHandler = createOrderCommandHandler;
        }

        public void CreateOrder(AddOrderRequest request)
        {
            var command = new CreateOrderCommand();
            command.UserId = request.UserId;
            _createOrderCommandHandler.Execute(command);
        }

        public Order GetOrder(int id)
        {
            return _getOrderQuery.GetOrder(id);
        }
    }
}
