using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week8Project.Core.Exceptions.Repositories;

namespace API.Controllers
{
    public class PriceListController : ControllerBase
    {
        private readonly IPriceListRepository _priceListRepository;
        private readonly IProductRepository _productRepository;

        public PriceListController(IPriceListRepository priceListRepository, IProductRepository productRepository)
        {
            _priceListRepository = priceListRepository;
            _productRepository = productRepository;
        }

        [HttpPost("AddPriceList")]
        public async Task<ActionResult> AddPriceList(PriceListAdd pricelist)
        {
            await _priceListRepository.AddPriceList(pricelist);
            return Ok("Success");
        }

        [HttpGet]
        public IEnumerable GetProduct(Guid ProductId)
        {
            return _productRepository.getProduct(ProductId);
        }
    }
}
