using Domain.Core.Repositories;
using Domain.Core.Services;
using Domain.Dto.Proveedor;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IProveedorService : IDomainService
    {
        bool Putproveedor(ProveedorPutDto proveedorPut);
        bool Deleteproveedor(Guid Id);
        ProveedorGetDto GetProveedorById(Guid id);
        IEnumerable<ProveedorGetDto> GetAllProveedor();
        bool Postproveedor(ProveedorPostDto proPost);

    }
}
