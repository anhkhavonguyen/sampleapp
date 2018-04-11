using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Sale.Message;
using SampleApp.Sale.Service;

namespace SampleApp.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Sale")]
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