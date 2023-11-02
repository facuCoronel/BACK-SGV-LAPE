using Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Stock : Entity<int>
    {
        public decimal Cantidad { get; set; }
        public Guid ProductoId { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
