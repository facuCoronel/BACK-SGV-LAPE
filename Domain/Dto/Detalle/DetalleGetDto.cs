using Domain.Dto.Maestro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Detalle
{
    public class DetalleGetDto : DetalleDto
    {
        public int Id { get; set; }
        public int MaestroId {  get; set; }
        //public MaestroGetDto Maestro { get; set; }
    }
}
