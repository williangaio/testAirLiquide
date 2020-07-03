
using System;

namespace AirTest.Domain.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void BeginTran();
        void RollBack();
        void Commit();
        void Update(TEntity cliente);
        void Insert(TEntity cliente);
        void Delete(Guid id);
    }
}
