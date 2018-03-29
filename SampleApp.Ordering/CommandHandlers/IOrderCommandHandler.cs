using SampleApp.Ordering.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Ordering.CommandHandlers
{
    public interface IOrderCommandHandler
    {
        void CreateOrder(CreateOrderCommand command);
    }
}
