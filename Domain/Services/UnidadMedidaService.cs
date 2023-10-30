using AutoMapper;
using Domain.Dto.UnidadMedida;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UnidadMedidaService : IUnidadMedidaService
    {
        private readonly IUnidadMedidaRepository _unidadMedidaRespository;
        private readonly IMapper _mapper;

        public UnidadMedidaService(IUnidadMedidaRepository unidadMedidaRespository, IMapper mapper)
        {
            _unidadMedidaRespository = unidadMedidaRespository;
            _mapper = mapper;
        }

        public bool PostUnidadMedida(UnidadMedidaPostDto um)
        {
            UnidadMedida oUm = new UnidadMedida();
            oUm.UnidadDeMedida = um.UnidadDeMedida;
            oUm.Diminutivo = um.Diminutivo;
            _unidadMedidaRespository.Add(oUm);
            _unidadMedidaRespository.Commit();

            return true;
        }

        public bool UpdateUnidadMedida(UnidadMedidaPutDto um)
        {
            var entity = _unidadMedidaRespository.GetById(um.Id);
            if (entity is null)
                throw new Exception("No se encontro la unidad de medida");

            entity.UnidadDeMedida = um.UnidadDeMedida;
            entity.Diminutivo = um.Diminutivo;

            _unidadMedidaRespository.Update(entity);
            _unidadMedidaRespository.Commit();

            return true;
        }


        public IEnumerable<UnidadMedidaGetDto> GetAll()
        {
            var entity = _unidadMedidaRespository.GetAll().ToList();
            var result = _mapper.Map<IEnumerable<UnidadMedidaGetDto>>(entity);
            return result;
        }
    }
}
