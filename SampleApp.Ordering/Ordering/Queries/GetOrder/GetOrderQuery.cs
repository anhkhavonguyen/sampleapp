using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleApp.Ordering.Domains;
using SampleApp.Ordering.Infrastructure.UnitOfWork;

namespace SampleApp.Ordering.Queries.GetOrder
{
    public class GetOrderQuery : IGetOrderQuery
    {
        private IUnitOfWork _unitOfWork;

        public GetOrderQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Order GetOrder(int id)
        {
            return _unitOfWork.OrderRepository.GetById(id);
        }
    }
}
