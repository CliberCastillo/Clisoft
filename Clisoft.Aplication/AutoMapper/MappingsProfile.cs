using AutoMapper;
using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.AutoMapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Rol, RolDTO>().ReverseMap();
        }
    }
}
