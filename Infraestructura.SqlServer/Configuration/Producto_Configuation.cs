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
    internal class Producto_Configuation : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.ToTable("Productos");

            // Propiedades
            builder.Property(p => p.Descripcion).IsRequired();
            builder.Property(p => p.Costo).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.PrecioVenta).HasColumnType("decimal(18, 2)").IsRequired();
            builder.Property(p => p.Origen);

            // Clave primaria
            builder.HasKey(p => p.Id);

            // Relación con Proveedor
            builder.HasOne(p => p.Proveedor) // Propiedad de navegación en Producto
                .WithMany(pr => pr.Productos)  // Propiedad de navegación en Proveedor
                .HasForeignKey(p => p.ProveedorId) // Clave foránea en Producto
                .OnDelete(DeleteBehavior.Restrict); // Acción de eliminación (puedes cambiar a Cascade si deseas eliminar productos relacionados)

            // Índice en la clave foránea (opcional)
            builder.HasIndex(p => p.ProveedorId);


            builder.HasOne(f => f.Floracion)
                .WithMany(fl => fl.Productos)
                .HasForeignKey(p => p.FloracionId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(c => c.Cantidad)
                .WithMany(ca => ca.Productos)
                .HasForeignKey(p => p.CantidadId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
