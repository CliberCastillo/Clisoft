using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Aplication.Interface.Entity;
using Clisoft.Domain.Entities;
using Clisoft.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.Service.Entity
{
    public class OrdenAppService : BaseAppService<OrdenDTO, Orden>, IOrdenAppService
    {
        private readonly IOrdenRepository _ordenRepository;
        public OrdenAppService(IOrdenRepository ordenRepository, IMapper mapper) : base(ordenRepository, mapper)
        {
            _ordenRepository = ordenRepository;
        }
    }
}
