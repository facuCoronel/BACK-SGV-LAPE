using Domain.Core.Repositories;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Infraestructura.SqlServer.Lape_DbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.SqlServer.Repositories
{
    public class UnidadMedidaRepository : BaseRepository<UnidadMedida>, IUnidadMedidaRepository
    {
        public UnidadMedidaRepository(LapeDbContext db) : base(db)
        {
        }
    }
}
