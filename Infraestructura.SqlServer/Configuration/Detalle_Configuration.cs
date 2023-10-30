using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.SqlServer.Configuration
{
    internal class Detalle_Configuration : IEntityTypeConfiguration<Detalle>
    {
        public void Configure(EntityTypeBuilder<Detalle> builder)
        {
            builder.ToTable("Detalle");


            builder.HasKey(d => d.Id);

            builder.HasOne(d => d.Maestro)
                .WithMany(m => m.Detalles)
                .HasForeignKey(d => d.MaestroId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Producto)
                .WithMany(m => m.Detalles)
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
