using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Proveedor : Entity<Guid>
    {
        public string NombreProveedor { get; set; }
        public string Email { get; set; }
        public string TelefonoFijo { get; set; }
        public string Celular { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
