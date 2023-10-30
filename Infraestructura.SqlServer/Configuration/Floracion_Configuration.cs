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
    internal class Floracion_Configuration : IEntityTypeConfiguration<Floracion>
    {
        public void Configure(EntityTypeBuilder<Floracion> builder)
        {
            builder.ToTable("Floraciones");
        }
    }
}
