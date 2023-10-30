using Domain.Entities;
using Domain.Interfaces.Repository;
using Infraestructura.SqlServer.Lape_DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.SqlServer.Repositories
{
    public class CantidadRespository : BaseRepository<Cantidad>, ICantidadRepository
    {
        public CantidadRespository(LapeDbContext db) : base(db)
        {
        }
    }
}
