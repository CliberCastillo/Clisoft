using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class IGenericRepository<T> : Domain.Interfaces.Repository.IGenericRepository<T> where T : class
    {
        private readonly ClisoftContext _context;
        private readonly DbSet<T> _dbSet;

        public IGenericRepository(ClisoftContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Add(T obj)
        {
            _dbSet.Add(obj);
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }
        public List<T> GetAll()
        {
            var listado = _dbSet.ToList();
            return listado;
        }

        public void Update(T obj)
        {
            _dbSet.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
