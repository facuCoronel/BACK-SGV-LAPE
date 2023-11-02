﻿using Domain.Entities;
using Domain.Interfaces.Repository;
using Infraestructura.SqlServer.Lape_DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.SqlServer.Repositories
{
    public class StockRepository : BaseRepository<Stock>, IStockRepository
    {
        public StockRepository(LapeDbContext db) : base(db)
        {
        }
    }
}
