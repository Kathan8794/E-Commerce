using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commercce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        [HttpGet]
        public async Task<IReadOnlyList<Product>> GetProduct()
        {
            return await _productRepository.GetProductsAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductbyId(int id)
        {
            return await _productRepository.GetProductByIdAsync(id);
        }
    }
}
