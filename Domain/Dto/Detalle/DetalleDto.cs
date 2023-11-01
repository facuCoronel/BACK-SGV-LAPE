using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Detalle
{
    public class DetalleDto
    {
        public Guid ProductoId { get; set; }
        public int Cantidad { get; set; }
    }
}
