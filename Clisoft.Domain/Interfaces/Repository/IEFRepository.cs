using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IEFRepository<T> where T : class
    {
        void Add(T obj);
        Task<T> GetByIdAsync(object id);
        //IQueryable<T> GetAll();
        //void Remove(object id);
        //void Update(T obj);
    }
}
