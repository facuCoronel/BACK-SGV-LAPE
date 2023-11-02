using AutoMapper;
using Domain.Dto.Cantidad;
using Domain.Dto.Cliente;
using Domain.Dto.Detalle;
using Domain.Dto.Floracion;
using Domain.Dto.Maestro;
using Domain.Dto.Producto;
using Domain.Dto.Proveedor;
using Domain.Dto.Stock;
using Domain.Dto.UnidadMedida;
using Domain.Dto.Ventas;
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

            //producto
            CreateMap<Producto, ProductoGetDto>();
            CreateMap<ProductoGetDto, Producto>();
            CreateMap<Producto, ProductoPostDto>();
            CreateMap<ProductoPostDto, Producto>();
            CreateMap<Producto, ProductoPutDto>();
            CreateMap<ProductoPutDto, Producto>();

            //maestro
            CreateMap<Maestro, MaestroPostDto>();
            CreateMap<MaestroPostDto, Maestro>();
            CreateMap<MaestroGetDto, Maestro>();
            CreateMap<Maestro, MaestroGetDto>();
            CreateMap<Maestro, MaestroPutDto>();
            CreateMap<MaestroPutDto, Maestro>();

            //detalle
            CreateMap<DetallePostDto, Detalle>();
            CreateMap<Detalle, DetallePostDto>();
            CreateMap<Detalle, DetalleGetDto>();
            CreateMap<DetalleGetDto, Detalle>();
            CreateMap<Detalle, DetallePutDto>();
            CreateMap<DetallePutDto, Detalle>();


            //stock
            CreateMap<StockPostDto, Stock>();
            CreateMap<Stock, StockPostDto>();
            CreateMap<StockPutDto,  Stock>();
            CreateMap<Stock, StockPutDto>();
            CreateMap<StockGetDto, Stock>();
            CreateMap<Stock, StockGetDto>();


            //ventas
            //CreateMap<VentasGetDto, MaestroGetDto>()
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.MaestroGet.Id));  // Configura el mapeo entre VentasGetDto y MaestroGetDto
        }
    }
}
