using Infraestructura.SqlServer.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.SqlServer.Lape_DbContext
{
    public class LapeDbContext : DbContext
    {
        public LapeDbContext(DbContextOptions options) : base(options)
        {
        }

        //DbSet<Origin> Origin { get; set; }
        //DbSet<Product> Product { get; set; }
        //DbSet<Stock> Stock { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //cliente
            modelBuilder.ApplyConfiguration(new Cliente_Configuration());
            //floracion
            modelBuilder.ApplyConfiguration(new Floracion_Configuration());
            //cantidad
            modelBuilder.ApplyConfiguration(new Cantidad_Configuration());
            //unidad medida
            modelBuilder.ApplyConfiguration(new UnidadMedida_Configuration());
            //producto
            modelBuilder.ApplyConfiguration(new Producto_Configuation());
            //proveedor
            modelBuilder.ApplyConfiguration(new Proveedor_Configuration());

        }
    }
}
