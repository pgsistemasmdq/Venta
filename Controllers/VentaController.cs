using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApiCoder.Modelos;
using WebApiCoder.Repository;

namespace WebApiCoder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpPost]
        public void CargarVenta([FromBody] VentaProducto vtas)
        {
            ADO_Venta.CargarVenta(vtas);
        }
        [HttpGet("GetVentas")]
        public List<Venta> Get()
        {
            return ADO_Venta.DevolverVenta();
        }

    }
}
