using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Producto
{
    public class ProductoDto
    {
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Origen { get; set; }
        public Guid ProveedorId { get; set; }
        public int CantidadId { get; set; }
        public int FloracionId { get; set; }
    }
}
