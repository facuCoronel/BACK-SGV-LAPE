using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cantidad : Entity<int>
    {
        public Cantidad()
        {
        }
        public int Valor { get; set; }
        public int UnidadMedidaId { get; set; }
        public virtual UnidadMedida UnidadMedida { get; set; }
        public virtual ICollection<Producto> Productos { get; set; }
    }
}
