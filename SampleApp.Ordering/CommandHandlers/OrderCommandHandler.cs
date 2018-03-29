using SampleApp.Business.CommandHandlers;
using SampleApp.Ordering.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Ordering.Command;
using SampleApp.Ordering.Infrastructure.Repositories;
using SampleApp.Ordering.Domains.Order;
using SampleApp.Business.Domains.Order.CommandModel;

namespace SampleApp.Ordering.CommandHandlers
{
    public class OrderCommandHandler : IOrderCommandHandler
    {
        private IUnitOfWork _unitOfWork;
        public OrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void CreateOrder(CreateOrderCommand command)
        {
            var commandOrder = new CommandOrder();
            
            //var orderRepository = _unitOfWork.OrderRepository.Add();
        }
    }
}
