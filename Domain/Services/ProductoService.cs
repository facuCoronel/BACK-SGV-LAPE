using AutoMapper;
using Domain.Dto.Producto;
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
    public class ProductoService : IProductoService
    {
        private readonly IProductoRepository _repository;
        private readonly IMapper _mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public bool PostProducto(ProductoPostDto prodPost)
        {
            var entity = _mapper.Map<Producto>(prodPost);
            _repository.Add(entity);
            _repository.Commit();

            return true;
        }

        public bool PutProducto(ProductoPutDto putProd)
        {
            var entity = _repository.GetById(putProd.Id);
            entity.PrecioVenta = putProd.PrecioVenta;
            entity.CantidadId = putProd.CantidadId;
            entity.FloracionId = putProd.FloracionId;
            entity.Descripcion = putProd.Descripcion;
            entity.Origen = putProd.Origen;
            entity.Costo = putProd.Costo;
            entity.ProveedorId = putProd.ProveedorId;

            _repository.Update(entity);
            _repository.Commit();

            return true;

        }

        public IEnumerable<ProductoGetDto> GetAll()
        {
            return _mapper.Map<IEnumerable<ProductoGetDto>>(_repository.GetAll());
        }

        public ProductoGetDto GetById(Guid id)
        {
            return _mapper.Map<ProductoGetDto>(_repository.GetById(id));
        }

        public bool DeleteProducto(Guid id)
        {
            _repository.Remove(_repository.GetById(id));
            _repository.Commit();
            return true;
        }
    }
}
