using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HPlusport.Controllers
{
    [Route("api/[controller])")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "OK";
        }
    }
}