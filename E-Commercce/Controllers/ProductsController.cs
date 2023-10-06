using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commercce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProduct()
        {
            return "All Product";
        }

        [HttpGet("{id}")]
        public string GetProductbyId(int id)
        {
            return "Product with id";
        }
    }
}
