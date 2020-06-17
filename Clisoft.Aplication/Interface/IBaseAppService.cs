using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Interface
{
    public interface IBaseAppService<ObjectDTO, T>
        where ObjectDTO : class
        where T : class
    {
        void Add(ObjectDTO obj);
        Task<ObjectDTO> GetByIdAsync(object id);
    }
}
