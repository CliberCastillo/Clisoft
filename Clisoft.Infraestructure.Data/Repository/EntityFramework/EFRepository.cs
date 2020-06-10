using Clisoft.Domain.Interfaces.Repository;
using Clisoft.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Clisoft.Infraestructure.Data.Repository.EntityFramework
{
    public class EFRepository<T> : IEFRepository<T> where T : class
    {
        private readonly BDMemoryKingsContext _context;
        private readonly DbSet<T> _dbSet;

        public EFRepository(BDMemoryKingsContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }
        public void Add(T obj)
        {
            _dbSet.Add(obj);
            _context.SaveChanges();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }
        //public IQueryable<T> GetAll()
        //{
        //    return _dbSet.AsNoTracking();
        //}


        //public void Remove(object id)
        //{
        //    _dbSet.Remove(_dbSet.Find(id));
        //}

        //public int SaveChanges()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(T obj)
        //{
        //    _dbSet.Update(obj);
        //}
    }
}
