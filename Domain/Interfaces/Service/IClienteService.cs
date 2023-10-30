using Domain.Core.Repositories;
using Domain.Core.Services;
using Domain.Dto.Cliente;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Service
{
    public interface IClienteService : IDomainService
    {
        public bool PostCliente(ClientePostDto cliPost);
        bool PutCliente(ClientePutDto clientePut);  
        bool DeleteCliente(Guid Id);    
        ClienteGetDto GetClienteById(Guid id);  
        IEnumerable<ClienteGetDto> GetAllCliente(); 

    }
}
