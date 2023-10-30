using AutoMapper;
using Domain.Dto.Cantidad;
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
    public class CantidadService : ICantidadService
    {
        private readonly ICantidadRepository _repository;
        private readonly IMapper _mapper;

        public CantidadService(IMapper mapper, ICantidadRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public bool PostCantidad(CantidadPostDto cant)
        {
            var cantidad = new Cantidad();
            cantidad.Valor = cant.Valor;
            cantidad.UnidadMedidaId = cant.UnidadMedidaId;

            _repository.Add(cantidad);
            _repository.Commit();
            return true;
        }

        public IEnumerable<CantidadGetDto> GetAllCantidad()
        {
            return _mapper.Map<IEnumerable<CantidadGetDto>>(_repository.GetAll().ToList());
        }

        public bool UpdateCantidad(CantidadPutDto can)
        {
            var entity = _repository.GetById(can.Id);
            if (entity is null)
                throw new Exception("No se encontro cantidad");

            entity.UnidadMedidaId = can.UnidadMedidaId;
            entity.Valor = can.Valor;
            _repository.Update(entity);
            _repository.Commit();
            return true;
        }
    }
}
