using Domain.Dto.Cliente;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteService _clienteService;

        public ClienteController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }


        [HttpPost]
        public IActionResult Post(ClientePostDto cliPost)
        {
            return Ok(_clienteService.PostCliente(cliPost));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_clienteService.GetAllCliente());
        }

        [HttpGet("GetById")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_clienteService.GetClienteById(id));
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            return Ok(_clienteService.DeleteCliente(id));
        }

        [HttpPut]
        public IActionResult Put(ClientePutDto clientePut)
        {
            return Ok(_clienteService.PutCliente(clientePut));
        }
    }
}
