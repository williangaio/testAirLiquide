using AirTest.Domain.Entities;
using AirTest.Domain.Repository.Interface;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirTest.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        AirTestContext _context;
        IDbContextTransaction tran;
        public ClienteRepository(AirTestContext context)
        {
            _context = context;
        }
        public IEnumerable<Cliente> All()
        {
            return _context.Cliente;
        }
        public Cliente GetById(Guid id)
        {
            return _context.Cliente.Find(id);
        }
        public void Update(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
        }
        public void Insert(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }
        public void Delete(Guid id)
        {
            Cliente cliente = this.GetById(id);
            _context.Cliente.Remove(cliente);
            _context.SaveChanges();
        }
        public void BeginTran()
        {
            tran = _context.Database.BeginTransaction();
        }
        public void Commit()
        {
            tran.Commit();
        }
        public void RollBack()
        {
            tran.Rollback();
        }
    }
}
