using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Maestro : Entity<int>
    {
        public Guid ClienteId { get; set; }
        public string Fecha { get; set; }
        public string FechaEntrega { get; set; }
        public string FechaAPagar { get; set; }
        public bool Pago { get; set; }
        public bool Entregado { get; set; }
        public decimal MontoPagado { get; set; }
        public decimal Total { get; set; }
        public int CantidadTotal { get; set; }
        public bool Estado { get; set; }

        public ICollection<Detalle> Detalles { get; set; }  // Relación de navegación uno a muchos con Detalle
        public virtual Cliente Cliente { get; set; }
    }
}
