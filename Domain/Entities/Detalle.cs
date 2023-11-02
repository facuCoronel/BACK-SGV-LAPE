using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Detalle : Entity<int>
    {
        public int MaestroId { get; set; }  // Clave foránea que referencia al Maestro
        public Guid ProductoId { get; set; }
        public int Cantidad { get; set; }
        public virtual Producto Producto { get; set; }
        public virtual Maestro Maestro { get; set; }  // Relación de navegación con Maestro
    }
}
