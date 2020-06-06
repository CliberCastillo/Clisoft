using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IEFRepository<T>  where T : class
    {
        void Add(T obj);
        T GetById(Guid id);
        IQueryable<T> GetAll();
        void Update(T obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
