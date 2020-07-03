using AirTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTest.Domain.Services.Interfaces
{
    public interface IClienteService
    {
        IEnumerable<Cliente> AllClientes();
        Cliente GetCliente(Guid id);
        void AddCliente(Cliente cliente);
        void updateCliente(Cliente cliente);
        void deleteCliente(Guid id);
    }
}
