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
    internal class Stock_Configuration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.ToTable("Stock");

            builder.HasKey(t => t.Id);

            builder.HasOne(t => t.Producto)
                .WithMany(t => t.Stocks)
                .HasForeignKey(t => t.ProductoId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);


        }
    }
}
