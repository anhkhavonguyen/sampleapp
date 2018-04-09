using SampleApp.Ordering.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Ordering.Services
{
    public interface IOrderService
    {
        void CreateOrder(AddOrderRequest request);
    }
}
