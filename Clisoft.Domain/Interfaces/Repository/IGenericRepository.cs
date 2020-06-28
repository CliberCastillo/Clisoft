using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Domain.Interfaces.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(object id);
        List<T> GetAll();
        void Add(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();
    }
}





















        //IQueryable<T> GetAll();
        //void Remove(object id);
        //void Update(T obj);