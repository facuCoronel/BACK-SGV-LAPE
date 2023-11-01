using Domain.Dto.Detalle;
using Domain.Dto.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Ventas
{
    public class VentasGetDto
    {
        public MaestroGetDto MaestroGet { get; set; }
        public List<DetalleGetDto> DetallesGet { get; set; }
    }
}
