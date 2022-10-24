using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiCoder.Modelos;
using WebApiCoder.Repository;

namespace WebApiCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet("GetProductosVendidos")]
        public List<ProductoVendido> Get()
        {
            return ADO_ProductoVendido.DevolverProductosVendidos();
        }

    }
}
