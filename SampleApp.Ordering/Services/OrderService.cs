using SampleApp.Ordering.CommandHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Ordering.Services
{
    public class OrderService : IOrderService
    {
        private IOrderCommandHandler _orderCommandHandler;
        public OrderService(IOrderCommandHandler orderCommandHandler)
        {
            _orderCommandHandler = orderCommandHandler;
        }
    }
}
