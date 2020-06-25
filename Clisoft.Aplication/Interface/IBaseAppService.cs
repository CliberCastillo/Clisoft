using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface
{
    public interface IBaseAppService<ObjectDTO, T>
        where ObjectDTO : class
        where T : class
    {
        Task<ObjectDTO> GetByIdAsync(object id);
        List<ObjectDTO> GetAll();
        void Add(ObjectDTO obj);
        void Update(ObjectDTO obj);
        void Delete(object id);
        void Save();
    }
}
