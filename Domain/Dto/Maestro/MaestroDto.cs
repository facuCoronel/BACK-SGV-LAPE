using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Maestro
{
    public class MaestroDto
    {
        public Guid ClienteId { get; set; }
        public string Fecha { get; set; }
        public string FechaEntrega { get; set; }
        public string FechaAPagar { get; set; }
        public bool Pago { get; set; }
        public bool Entregado { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Total { get; set; }
        public bool Estado { get; set; }
        public int CantidadTotal { get; set; }
    }
}
