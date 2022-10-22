using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using WebApplication1.Modelos;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpPost]
        public void CargarVenta([FromBody] List<ProductoVendido> prodVendidos, string comentarios, int idUsuario)
        {
            ADO_Venta.CargarVenta(prodVendidos, comentarios, idUsuario);

        }


    }
}
