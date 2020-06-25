using AutoMapper;
using Clisoft.Domain.Entities;

namespace Clisoft.Aplication.AutoMapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Cargo, CargoDTO>().ReverseMap();
        }
    }
}
