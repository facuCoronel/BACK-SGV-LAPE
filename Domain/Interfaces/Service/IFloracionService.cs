using Domain.Core.Services;
using Domain.Dto.Floracion;
using Domain.Dto.UnidadMedida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IFloracionService : IDomainService
    {

        bool PostFloracion(string tipo);
        bool PutFloracion(FloracionPutDto fl);
        IEnumerable<FloracionGetDto> GetAllFloracion();


    }
}
