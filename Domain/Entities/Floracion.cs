using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Floracion : Entity<int>
    {
        public string Tipo { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
