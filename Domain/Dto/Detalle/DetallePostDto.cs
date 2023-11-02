using Domain.Dto.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Detalle
{
    public class DetallePostDto : DetalleDto
    {
        public int MaestroId { get; set; }
    }
}
