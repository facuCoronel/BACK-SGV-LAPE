using Domain.Core.Services;
using Domain.Dto.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IStockService : IDomainService
    {
        bool InsertStock(StockPostDto stockPostDto);
        bool ActualizarStock(StockPutDto stockPutDto);
        IEnumerable<StockGetDto> GetAllStock();
        StockGetDto GetByIdStock(int id);
        bool DeleteStockById(int id);

    }
}
