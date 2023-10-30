using AutoMapper;
using Domain.Dto.Cliente;
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
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteService(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public bool PostCliente(ClientePostDto cliPost)
        {
            var entity = _mapper.Map<Cliente>(cliPost);
            _clienteRepository.Add(entity);
            _clienteRepository.Commit();

            return true;
        }

        public bool PutCliente(ClientePutDto clientePut)
        {
            var entity = _clienteRepository.GetById(clientePut.Id);

            entity.NombreCliente = clientePut.NombreCliente;
            entity.Celular = clientePut.Celular;
            entity.TelefonoFijo = clientePut.TelefonoFijo;
            entity.Email = clientePut.Email;
            
            _clienteRepository.Update(entity);
            _clienteRepository.Commit();
            return true;
        }


        public bool DeleteCliente(Guid Id)
        {
            var getcliente = _clienteRepository.GetById(Id);
            _clienteRepository.Remove(getcliente);
            _clienteRepository.Commit();

            return true;
        }

        public ClienteGetDto GetClienteById(Guid id)
        {
            return _mapper.Map<ClienteGetDto>(_clienteRepository.GetById(id));
        }

        public IEnumerable<ClienteGetDto> GetAllCliente()
        {
            return _mapper.Map<IEnumerable<ClienteGetDto>>(_clienteRepository.GetAll());
        }




    }
}
