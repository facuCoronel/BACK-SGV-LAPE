using Domain.Dto.Cantidad;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CantidadController : ControllerBase
    {
        private readonly ICantidadService _cantidadService;

        public CantidadController(ICantidadService cantidadService)
        {
            _cantidadService = cantidadService;
        }


        [HttpPost]
        public IActionResult Post(CantidadPostDto cant)
        {
            return Ok(_cantidadService.PostCantidad(cant));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_cantidadService.GetAllCantidad());
        }

        [HttpPut]
        public IActionResult Put(CantidadPutDto can)
        {
            return Ok(_cantidadService.UpdateCantidad(can));
        }
    }
}
