using Domain.Dto.UnidadMedida;
using Domain.Entities;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadMedidaController : ControllerBase
    {
        private readonly IUnidadMedidaService _IUnidadMedidaService;

        public UnidadMedidaController(IUnidadMedidaService iUnidadMedidaService)
        {
            _IUnidadMedidaService = iUnidadMedidaService;
        }


        [HttpPost]
        public IActionResult Post(UnidadMedidaPostDto um)
        {
            return Ok(_IUnidadMedidaService.PostUnidadMedida(um));
        }


        [HttpPut]
        public IActionResult Put(UnidadMedidaPutDto putUm)
        {
            return Ok(_IUnidadMedidaService.UpdateUnidadMedida(putUm));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_IUnidadMedidaService.GetAll());
        }
    }
}
