using Domain.Dto.Detalle;
using Domain.Dto.Maestro;
using Domain.Dto.Ventas;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private readonly IVentasService _ventasService;

        public VentasController(IVentasService ventasService)
        {
            _ventasService = ventasService;
        }

        [HttpPost]
        public IActionResult Post(VentasDto ventasDto)
        {
            return Ok(_ventasService.PostVenta(ventasDto));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ventasService.GetAll());
        }

        [HttpDelete("DeleteDetalleById")]
        public IActionResult DeteleDetalleById(int idDetalle, int idMaestro)
        {
            return Ok(_ventasService.DeleteDetalleById(idDetalle,idMaestro));
        }

        [HttpDelete]
        public IActionResult Delete(int idMaestro)
        {
            return Ok(_ventasService.DeteleAllFacturaAndDetalles(idMaestro));
        }

        [HttpPut("UpdateDetalle")]
        public IActionResult PutDetalle(DetallePutDto detallePutDto)
        {
            return Ok(_ventasService.ActualizarDetalle(detallePutDto));
        }

        [HttpPut]
        public IActionResult PutMaestro(MaestroPutDto maestroPutDto)
        {
            return Ok(_ventasService.ActualizarMaestro(maestroPutDto));
        }
    }
}
