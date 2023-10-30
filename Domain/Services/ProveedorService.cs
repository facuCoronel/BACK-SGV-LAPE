using AutoMapper;
using Domain.Dto.Proveedor;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ProveedorService : IProveedorService
    {
        private readonly IProveedorRepository _proveedorRepository;
        private readonly IMapper _mapper;

        public ProveedorService(IProveedorRepository proveedorRepository, IMapper mapper)
        {
            _proveedorRepository = proveedorRepository;
            _mapper = mapper;
        }


        public bool Postproveedor(ProveedorPostDto proPost)
        {
            var entity = _mapper.Map<Proveedor>(proPost);
            _proveedorRepository.Add(entity);
            _proveedorRepository.Commit();

            return true;
        }

        public bool Putproveedor(ProveedorPutDto proveedorPut)
        {
            var entity = _proveedorRepository.GetById(proveedorPut.Id);

            entity.NombreProveedor = proveedorPut.NombreProveedor;
            entity.Celular = proveedorPut.Celular;
            entity.TelefonoFijo = proveedorPut.TelefonoFijo;
            entity.Email = proveedorPut.Email;

            _proveedorRepository.Update(entity);
            _proveedorRepository.Commit();
            return true;
        }


        public bool Deleteproveedor(Guid Id)
        {
            var getProveedor= _proveedorRepository.GetById(Id);
            _proveedorRepository.Remove(getProveedor);
            _proveedorRepository.Commit();

            return true;
        }

        public ProveedorGetDto GetProveedorById(Guid id)
        {
            return _mapper.Map<ProveedorGetDto>(_proveedorRepository.GetById(id));
        }

        public IEnumerable<ProveedorGetDto> GetAllProveedor()
        {
            return _mapper.Map<IEnumerable<ProveedorGetDto>>(_proveedorRepository.GetAll());
        }
    }
}
