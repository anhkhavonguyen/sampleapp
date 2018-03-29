using SampleApp.Ordering.CommandHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Business.Message;
using SampleApp.Ordering.Command;
using SampleApp.Ordering.Domains.Order.QueryModel;
using SampleApp.Ordering.Infrastructure.UnitOfWork;

namespace SampleApp.Ordering.Services
{
    public class OrderService : IOrderService
    {
        private UnitOfWork _unitOfWork;
        private IOrderCommandHandler _orderCommandHandler;
        public OrderService(IOrderCommandHandler orderCommandHandler, UnitOfWork unitOfWork)
        {
            _orderCommandHandler = orderCommandHandler;
            _unitOfWork = unitOfWork;
        }

        public void CreateOrder(AddOrderRequest request)
        {
            var command = new CreateOrderCommand();
            command.UserId = request.UserId;
            _orderCommandHandler.CreateOrder(command);
        }

        public QueryOrder GetOrderById(int id)
        {
            var order = _unitOfWork.OrderRepository.GetById(id);
            return new QueryOrder()
            {
                Id = order.Id
            };
        }
    }
}
