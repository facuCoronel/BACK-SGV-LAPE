using Domain.Dto.Detalle;
using Domain.Dto.Maestro;
using Domain.Dto.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IVentasService
    {
        bool PostVenta(VentasDto ventasDto);
        IEnumerable<object> GetAll();
        bool DeleteDetalleById(int idDetalle, int idMaestro);
        bool DeteleAllFacturaAndDetalles(int idMaestro);
        bool ActualizarDetalle(DetallePutDto detallePutDto);
        bool ActualizarMaestro(MaestroPutDto maestroPutDto);



    }
}
