using SampleApp.Ordering.Domains;
using SampleApp.Ordering.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Business.Ordering.Command.CreateOrderCommand
{
    public class CreateOrderCommandHandler : ICreateOrderCommandHandler
    {
        private IUnitOfWork _unitOfWork;
        public CreateOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Execute(CreateOrderCommand command)
        {
            var order = new Order();
            order.UserId = command.UserId;
            _unitOfWork.OrderRepository.Add(order);
        }
    }
}
