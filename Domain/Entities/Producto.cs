using Domain.Core;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Producto : Entity<Guid>
    {
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Origen { get; set; }
        public Guid ProveedorId { get; set; }
        public int CantidadId { get; set; }
        public int FloracionId { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Cantidad Cantidad { get; set; }
        public virtual Floracion Floracion { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }

        public Producto()
        {
            
        }
    }
}
