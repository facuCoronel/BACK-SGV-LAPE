using Domain.Dto.Producto;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_productoService.GetAll());
        }

        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_productoService.GetById(id));
        }

        [HttpPost]
        public IActionResult Post(ProductoPostDto prodPost)
        {
            return Ok(_productoService.PostProducto(prodPost));
        }

        [HttpPut]
        public IActionResult Put(ProductoPutDto prodPut)
        {
            return Ok(_productoService.PutProducto(prodPut));
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            return Ok(_productoService.DeleteProducto(id));
        }

    }
}
