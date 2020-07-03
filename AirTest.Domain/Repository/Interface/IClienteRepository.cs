using AirTest.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AirTest.Domain.Repository.Interface
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        IEnumerable<Cliente> All();
        Cliente GetById(Guid id);
    }
}
