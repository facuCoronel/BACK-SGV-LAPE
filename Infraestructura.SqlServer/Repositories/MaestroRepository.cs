using Domain.Entities;
using Domain.Interfaces.Repository;
using Infraestructura.SqlServer.Lape_DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Infraestructura.SqlServer.Repositories
{
    public class MaestroRepository : BaseRepository<Maestro>, IMaestroRepository
    {
        public MaestroRepository(LapeDbContext db) : base(db)
        {
        }

        public decimal GetPrecioProductoById(Guid id)
        {
            return base.GetById<Producto>(id).PrecioVenta;
        }


        public bool ActualizarStockVentas(Guid productoId, decimal cantidad)
        {
            var update = base.ForFilter<Stock>(x => x.ProductoId == productoId).FirstOrDefault();

            update.Cantidad = update.Cantidad - cantidad;

            base.Update(update);

            return true;
            
        }
    }
}
