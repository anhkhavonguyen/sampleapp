using SampleApp.Sale.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Sale.Service
{
    public interface ISaleService
    {
        List<ProductViewModel> GetProducts();
    }
}
