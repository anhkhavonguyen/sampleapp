using SampleApp.Ordering.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Ordering.Queries.GetOrder
{
    public interface IGetOrderQuery
    {
        Order GetOrder(int id); 
    }
}
