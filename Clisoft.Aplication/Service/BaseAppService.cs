using AutoMapper;
using Clisoft.Aplication.Interface;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clisoft.Aplication.Service
{
    public class BaseAppService<ObjectDTO, T> : IBaseAppService<ObjectDTO, T>
        where ObjectDTO : class
        where T : class
    {
        private readonly IEFRepository<T> _eFRepositoy;

        public readonly IMapper _mapper;

        public BaseAppService(IEFRepository<T> eFRepository, IMapper mapper)
        {
            _eFRepositoy = eFRepository;
            _mapper = mapper;
        }

        public void Add(ObjectDTO obj)
        {
            _eFRepositoy.Add(_mapper.Map<T>(obj));
        }

        public Task<ObjectDTO> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }
    }
}
