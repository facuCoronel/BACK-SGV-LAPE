using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Producto
{
    public class ProductoPutDto : ProductoDto
    {
        public Guid Id { get; set; }
    }
}
