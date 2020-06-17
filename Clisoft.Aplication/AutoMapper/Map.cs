using AutoMapper;
using Clisoft.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clisoft.Aplication.AutoMapper
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<Rol, RolDTO>();
        }
    }
}
