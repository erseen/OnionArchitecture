using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Application.Interfaces.Repository;
using System.Runtime.InteropServices;

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRespository productRespository;

        public ProductController(IProductRespository productRespository)
        {
            this.productRespository = productRespository;
        }

        [HttpGet]
        public async Task <IActionResult>Get()
        {
           var Alllist = await productRespository.GetAllAsync();
        }
    }
}
