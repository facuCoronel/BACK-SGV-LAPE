using Domain.Core.Repositories;
using Domain.Core.Services;
using Domain.Dto.Cantidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface ICantidadService : IDomainService
    {
       bool PostCantidad(CantidadPostDto cant);
       IEnumerable<CantidadGetDto> GetAllCantidad();
        bool UpdateCantidad(CantidadPutDto can);
    }
}
