using Domain.Dto.Cliente;
using Domain.Dto.Proveedor;
using Domain.Interfaces.Service;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private IProveedorService _proveedorService;
        public ProveedorController(IProveedorService proveedorService)
        {
            _proveedorService = proveedorService;
        }

        [HttpPost]
        public IActionResult Post(ProveedorPostDto cliPost)
        {
            return Ok(_proveedorService.Postproveedor(cliPost));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_proveedorService.GetAllProveedor());
        }

        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_proveedorService.GetProveedorById(id));
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            return Ok(_proveedorService.Deleteproveedor(id));
        }

        [HttpPut]
        public IActionResult Put(ProveedorPutDto proveedorPut)
        {
            return Ok(_proveedorService.Putproveedor(proveedorPut));
        }
    }
}
