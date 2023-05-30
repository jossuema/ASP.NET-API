using DemoTaller.Models;
using DemoTaller.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoTaller.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) { 
           this._productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProduct() {
            
            return Ok(this._productService.GetAllProducts());
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductModel model)
        {
            _productService.CreateProduct(model);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteProduct([FromQuery] int id)
        {
            _productService.DeleteProduct(id);
            
            return Ok();
        }

        [HttpGet]
        [Route("getproduct/{id}")]
        public IActionResult GetProduct(int id)
        {
            ProductEntity product = _productService.GetProduct(id);
            return Ok(product);
        }

        [HttpPut]
        public IActionResult UpdateProduct([FromBody] ProductEntity model)
        {
            _productService.UpdateProduct(model);
            return Ok();
        }
    }
}
