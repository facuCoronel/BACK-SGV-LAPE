using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Stock
{
    public class StockDto
    {
        public decimal Cantidad { get; set; }
        public Guid ProductoId { get; set; }
    }
}
