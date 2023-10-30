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
    internal class Cantidad_Configuration : IEntityTypeConfiguration<Cantidad>
    {
        public void Configure(EntityTypeBuilder<Cantidad> builder)
        {
            builder.ToTable("Cantidades");

            builder.HasKey(x => x.Id);

            builder.HasOne(c => c.UnidadMedida)
                .WithMany(ca => ca.Cantidades)
                .HasForeignKey(c => c.UnidadMedidaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
