using Domain.Core.Services;
using Domain.Dto.UnidadMedida;
using Domain.Entities;
using Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IUnidadMedidaService : IDomainService 
    {
        bool PostUnidadMedida(UnidadMedidaPostDto um);
        bool UpdateUnidadMedida(UnidadMedidaPutDto um);
        IEnumerable<UnidadMedidaGetDto> GetAll();
    }
}
