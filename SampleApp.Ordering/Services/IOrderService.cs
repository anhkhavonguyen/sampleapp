using SampleApp.Business.Message;
using SampleApp.Ordering.Domains.Order.QueryModel;
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

        QueryOrder GetOrderById(int id);
    }
}
