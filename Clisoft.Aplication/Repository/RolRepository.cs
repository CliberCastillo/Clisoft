using Clisoft.Aplication.Interface;
using Clisoft.Domain.Entity;
using Clisoft.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Repository
{
    public class RolRepository : IEFRepository<Rol>, IRolRepository

    {
        public void Add(Rol obj)
        {
            Add(obj);
        }

        public async Task<Rol> GetByIdAsync(object id)
        {
            return await GetByIdAsync(id);
            
        }
    }
}
