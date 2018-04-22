using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Sale.Message;
using SampleApp.Sale.Service;

namespace SampleApp.Sale.Api.Controllers
{
    [Route("api/[controller]")]
    public class SaleController : Controller
    {
        private ISaleService _saleService;
        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }

        [HttpGet]
        public List<ProductViewModel> Get()
        {
            return _saleService.GetProducts();
        }
    }
}
