using Domain.Dto.Floracion;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloracionController : ControllerBase
    {
        private readonly IFloracionService _floracionService;

        public FloracionController(IFloracionService floracionService)
        {
            _floracionService = floracionService;
        }

        [HttpPost]
        public IActionResult Post(string tipo)
        {
            return Ok(_floracionService.PostFloracion(tipo));
        }

        [HttpPut]
        public IActionResult Put(FloracionPutDto fl)
        {
            return Ok(_floracionService.PutFloracion(fl));
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_floracionService.GetAllFloracion());
        }
    }
}
