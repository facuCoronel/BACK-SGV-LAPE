using Domain.Dto.Floracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Dto.Producto
{
    public class ProductoGetDto : ProductoDto
    {
        public Guid Id { get; set; }
        public FloracionProductDto Floracion {  get; set; }
        public ProveedorProductDto Proveedor { get; set; }
        public CantidadProductDto Cantidad { get; set; }
    }


    public class FloracionProductDto
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
    }

    public class ProveedorProductDto
    {
        public Guid Id { get; set; }
        public string NombreProveedor { get; set; }
    }

    public class CantidadProductDto
    {
        public int Id { get; set; }
        public int Valor { get; set; }
        public UnidadMedidaCantidadProductDto UnidadMedida { get; set; }

    }

    public class UnidadMedidaCantidadProductDto
    {
        public int Id { get; set; }
        public string UnidadDeMedida { get; set; }
        public string Diminutivo { get; set; }
    }
}
