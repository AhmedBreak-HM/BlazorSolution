using Blazor.Contracts;
using Blazor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.API.Controllers
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
        [HttpGet]
        public ActionResult<List<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }
        [HttpGet("GetById")]
        public ActionResult<Product> GetProductById(int id)
        {
            return _productService.GetProductById(id);
        }
        [HttpPost("Add")]
        public ActionResult<Product> AddProduct(Product product)
        {
            _productService.AddProduct(product);
            return product;
        }
        [HttpPost("Update")]
        public ActionResult<Product> UpdateProduct(Product product)
        {
            _productService.UpdateProduct(product);
            return product;
        }
        [HttpDelete("{id}")]
        public ActionResult<Product> DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok("deleted product");
        }
    }
}
