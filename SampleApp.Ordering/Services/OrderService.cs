using SampleApp.Business.Ordering.Command.CreateOrderCommand;
using SampleApp.Ordering.Infrastructure.UnitOfWork;
using SampleApp.Ordering.Message;

namespace SampleApp.Ordering.Services
{
    public class OrderService : IOrderService
    {
        private UnitOfWork _unitOfWork;
        public OrderService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateOrder(AddOrderRequest request)
        {
            //var command = new CreateOrderCommand();
            //command.UserId = request.UserId;
            //_orderCommandHandler.CreateOrder(command);
        }

        //public QueryOrder GetOrderById(int id)
        //{
        //    var order = _unitOfWork.OrderRepository.GetById(id);
        //    return new QueryOrder()
        //    {
        //        Id = order.Id
        //    };
        //}
    }
}
