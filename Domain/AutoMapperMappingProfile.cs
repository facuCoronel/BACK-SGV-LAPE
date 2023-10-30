using AutoMapper;
using Domain.Dto.Cantidad;
using Domain.Dto.Cliente;
using Domain.Dto.Floracion;
using Domain.Dto.Proveedor;
using Domain.Dto.UnidadMedida;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AutoMapperMappingProfile : Profile
    {
        public AutoMapperMappingProfile()
        {
            //unidad medida
            CreateMap<UnidadMedida, UnidadMedidaGetDto>();

            //cantidad
            CreateMap<Cantidad, CantidadGetDto>();

            //floracion
            CreateMap<Floracion, FloracionGetDto>();


            //cliente
            CreateMap<Cliente, ClientePostDto>();
            CreateMap<ClientePostDto, Cliente>();
            CreateMap<ClienteGetDto, Cliente>();
            CreateMap<Cliente, ClienteGetDto>();
            CreateMap<ClientePutDto, Cliente>();
            CreateMap<Cliente, ClientePutDto>();

            //proveedor
            CreateMap<Proveedor, ProveedorPostDto>();
            CreateMap<ProveedorPostDto, Proveedor>();
            CreateMap<ProveedorGetDto, Proveedor>();
            CreateMap<Proveedor, ProveedorGetDto>();
            CreateMap<ProveedorPutDto, Proveedor>();
            CreateMap<Proveedor, ProveedorPutDto>();
        }
    }
}
