using Microsoft.AspNetCore.Mvc;
using ProductAPI.Model;
using ProductAPI.Service;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAllProduct")]

        public IEnumerable<Product> GetAllProduct()
        {
            return _productService.GetProductList();
        }

        [HttpGet("{id}")]

        public Product GetProductById(int id)
        {
            return _productService.GetProductById(id);
        }

        [HttpPost("AddProduct")]

        public Product AddProduct(Product product)
        {
            return _productService.AddProduct(product);
        }

        [HttpPut("UpdateProduct")]
        public Product UpdateProduct(Product product)
        {
            return _productService.UpdateProduct(product);
        }

        [HttpDelete("{id}")]
        public bool DeleteProduct(int id)
        {
            return _productService.DeleteProduct(id);
        }
    }
}
