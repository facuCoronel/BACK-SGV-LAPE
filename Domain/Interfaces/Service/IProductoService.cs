using Domain.Dto.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IProductoService
    {
        bool PostProducto(ProductoPostDto prodPost);
        bool PutProducto(ProductoPutDto putProd);
        IEnumerable<ProductoGetDto> GetAll();
        ProductoGetDto GetById(Guid id);
        bool DeleteProducto(Guid id);

    }
}
