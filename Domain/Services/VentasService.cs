using AutoMapper;
using Domain.Dto.Detalle;
using Domain.Dto.Maestro;
using Domain.Dto.Ventas;
using Domain.Entities;
using Domain.Interfaces.Repository;
using Domain.Interfaces.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class VentasService : IVentasService
    {
        private readonly IMapper _mapper;
        private readonly IMaestroRepository _maestroRepository;
        private readonly IDetalleRepository _detalleRepository;


        public VentasService(IMapper mapper, IMaestroRepository maestroRepository, IDetalleRepository detalleRepository)
        {
            _mapper = mapper;
            _maestroRepository = maestroRepository;
            _detalleRepository = detalleRepository;
        }

        public bool PostVenta(VentasDto ventasDto)
        {
            var maestroInsert = _mapper.Map<Maestro>(ventasDto.MaestroDto);

            foreach(var item in ventasDto.DetallePosts)
            {
                maestroInsert.CantidadTotal += item.Cantidad;
                maestroInsert.Total += item.Cantidad * _maestroRepository.GetPrecioProductoById(item.ProductoId);
            }

            _maestroRepository.Add(maestroInsert);

            _maestroRepository.Commit();

            var maestroId = _maestroRepository.GetAll().Last().Id;

            var detalleInsert = _mapper.Map<List<Detalle>>(ventasDto.DetallePosts);

            foreach(var detalle in detalleInsert)
            {
                detalle.MaestroId = maestroId;
                _detalleRepository.Add(detalle);
            }

            _detalleRepository.Commit();
            return true;
        }

        public IEnumerable<object> GetAll()
        {
            var maestros = _maestroRepository.GetAll();
            var detalles = _detalleRepository.GetAll();
            var maestrosDto = _mapper.Map<IEnumerable<MaestroGetDto>>(maestros);
            var detallesDto = _mapper.Map<IEnumerable<DetalleGetDto>>(detalles);

            var query = from maestro in maestrosDto
                        join detalle in detallesDto on maestro.Id equals detalle.MaestroId
                        group detalle by maestro into maestroGroup
                        select new
                        {
                            MaestroGet = maestroGroup.Key,
                            DetallesGet = maestroGroup.ToList()
                        };


            var result = query.ToList();
            //var ventasDtos = _mapper.Map<List<VentasGetDto>>(result); // no soporta el mapeo por lo que es result = List<a`> 
            return result;
        }

        public bool DeleteDetalleById(int idDetalle, int idMaestro)
        {
            var detalle = _detalleRepository.ForFilter<Detalle>(de => de.Id == idDetalle && de.MaestroId == idMaestro).FirstOrDefault();

            _detalleRepository.Remove(detalle);
            _detalleRepository.Commit();

            return true;
        }


        public bool DeteleAllFacturaAndDetalles(int idMaestro)
        {
            var detalles = _detalleRepository.ForFilter<Detalle>(de => de.MaestroId == idMaestro).ToList();

            foreach(var detalle in detalles)
                _detalleRepository.Remove(detalle);

            _detalleRepository.Commit();

            var maestro = _maestroRepository.GetById(idMaestro);

            _maestroRepository.Remove(maestro);
            _maestroRepository.Commit();

            return true;
        }

        public bool ActualizarDetalle(DetallePutDto detallePutDto)
        {
            bool actualizarMaestro = false;

            var detalleById = _detalleRepository.GetById(detallePutDto.Id);

            if (detalleById.Cantidad != detallePutDto.Cantidad) actualizarMaestro = true;


            detalleById.Cantidad = detallePutDto.Cantidad;
            detalleById.ProductoId = detallePutDto.ProductoId;

            _detalleRepository.Update(detalleById);
            _detalleRepository.Commit();

            if(actualizarMaestro == true)
            {
                var nuevosDetalles = _detalleRepository.ForFilter<Detalle>(des => des.MaestroId == detalleById.MaestroId).ToList();
                var maestro = _maestroRepository.GetById(detalleById.MaestroId);
                maestro.CantidadTotal = 0;
                foreach (var item in nuevosDetalles)
                {
                    maestro.CantidadTotal += item.Cantidad;
                    maestro.Total += item.Cantidad * _maestroRepository.GetPrecioProductoById(item.ProductoId);
                }

                _maestroRepository.Update(maestro);
                _maestroRepository.Commit();
            }
            return true;

        }

        public bool ActualizarMaestro(MaestroPutDto maestroPutDto)
        {

            var maestroRecuperado = _maestroRepository.GetById(maestroPutDto.Id);

            maestroRecuperado.Pago = maestroPutDto.Pago;
            maestroRecuperado.Fecha = maestroPutDto.Fecha;
            maestroRecuperado.FechaEntrega = maestroPutDto.FechaEntrega;
            maestroRecuperado.FechaAPagar = maestroPutDto.FechaAPagar;
            maestroRecuperado.Entregado = maestroPutDto.Entregado;
            maestroRecuperado.MontoPagado = maestroPutDto.MontoPagado;
            maestroRecuperado.Estado = maestroPutDto.Estado;
            maestroRecuperado.ClienteId = maestroPutDto.ClienteId;


            _maestroRepository.Update(maestroRecuperado);
            _maestroRepository.Commit();

            return true;
        }
    }
}
