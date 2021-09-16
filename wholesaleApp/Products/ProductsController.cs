using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using wholesaleApp.Products;

namespace wholesaleApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepository;

        public ProductsController(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productsRepository.GetAll();
        }

        [HttpPost]
        public IActionResult Add([FromBody] Product product)
        {
            _productsRepository.Add(product);
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete([FromQuery(Name = "productId")] string productId)
        {
            _productsRepository.Delete(productId);
            return Ok();
        }
    }
}
