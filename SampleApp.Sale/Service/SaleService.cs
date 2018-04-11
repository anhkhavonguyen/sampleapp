using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using SampleApp.Sale.Message;
using SampleApp.Sale.Persistance;

namespace SampleApp.Sale.Service
{
    public class SaleService : ISaleService
    {
        private ISaleDbContext _saleDbContext;
        public SaleService(ISaleDbContext saleDbContext)
        {
            _saleDbContext = saleDbContext;
        }

        public List<ProductViewModel> GetProducts()
        {
            return _saleDbContext.ProductCollection.AsQueryable().ToList().Select(p => new ProductViewModel()
            {
                Id = p.Id,
                ProductName = p.Name
            }).ToList();
        }
    }
}
