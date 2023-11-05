using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Stock
{
    public class StockGetDto : StockDto
    {
        public int Id { get; set; }
        public StockProductoGetDto Producto { get; set; }
    }

    public class StockProductoGetDto
    {
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Origen { get; set; }
        public Guid ProveedorId { get; set; }
        public int CantidadId { get; set; }
        public int FloracionId { get; set; }
        public StockCantidadDto Cantidad { get; set; }
    }

    public class StockCantidadDto
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public StockUnidadMedidaCantidadStockDto UnidadMedida { get; set; }

    }

    public class StockUnidadMedidaCantidadStockDto
    {
        public int Id { get; set; }
        public string UnidadDeMedida { get; set; }
        public string Diminutivo { get; set; }
    }
}
