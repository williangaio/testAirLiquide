using AirTest.Domain.Entities;
using AirTest.Domain.Repository.Interface;
using AirTest.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTest.Domain.Services
{
    public class ClienteService : IClienteService
    {
        IClienteRepository _clienteRepository;
        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public IEnumerable<Cliente> AllClientes()
        {
            return _clienteRepository.All();
        }
        public void AddCliente(Cliente cliente)
        {
            try
            {
                _clienteRepository.BeginTran();
                _clienteRepository.Insert(cliente);
                _clienteRepository.Commit();
            }
            catch (Exception ex)
            {
                _clienteRepository.RollBack();
                throw ex;
            }
        }
        public void deleteCliente(Guid id)
        {
            try
            {
                _clienteRepository.BeginTran();
                _clienteRepository.Delete(id);
                _clienteRepository.Commit();
            }
            catch (Exception ex)
            {
                _clienteRepository.RollBack();
                throw ex;
            }
        }
        public Cliente GetCliente(Guid id)
        {
            return _clienteRepository.GetById(id);
        }
        public void updateCliente(Cliente cliente)
        {
            try
            {
                _clienteRepository.BeginTran();
                _clienteRepository.Update(cliente);
                _clienteRepository.Commit();
            }
            catch (Exception ex)
            {
                _clienteRepository.RollBack();
                throw ex;
            }
        }
    }
}
