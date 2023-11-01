using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Detalle
{
    public class DetallePutDto : DetalleDto
    {
        public int Id { get; set; }
        public int IdMaestro { get; set; }
    }
}
