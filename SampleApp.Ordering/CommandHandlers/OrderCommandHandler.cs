using SampleApp.Business.CommandHandlers;
using SampleApp.Ordering.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Ordering.CommandHandlers
{
    public class OrderCommandHandler : IOrderCommandHandler
    {
        private IUnitOfWork _unitOfWork;
        public OrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
