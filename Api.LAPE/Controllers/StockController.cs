using Domain.Dto.Stock;
using Domain.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.LAPE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("GetById")]
        public IActionResult GetById(int id)
        {
            return Ok(_stockService.GetByIdStock(id));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_stockService.GetAllStock());
        }

        [HttpDelete]
        public IActionResult DeleteStock(int id)
        {
            return Ok(_stockService.DeleteStockById(id));
        }

        [HttpPut]
        public IActionResult PutStock(StockPutDto stockPutDto)
        {
            return Ok(_stockService.ActualizarStock(stockPutDto));
        }

        [HttpPost]
        public IActionResult PostStock(StockPostDto stockPostDto)
        {
            return Ok(_stockService.InsertStock(stockPostDto));
        }

    }
}
