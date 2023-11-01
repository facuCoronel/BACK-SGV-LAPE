using Domain.Dto.Detalle;
using Domain.Dto.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Ventas
{
    public class VentasDto
    {
        public MaestroPostDto MaestroDto { get; set; }
        public List<DetallePostDto> DetallePosts { get; set;} /*= new List<DetallePostDto>();*/
    }
}
