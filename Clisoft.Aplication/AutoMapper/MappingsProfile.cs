using AutoMapper;
using Clisoft.Aplication.DTO;
using Clisoft.Domain.Entities;

namespace Clisoft.Aplication.AutoMapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Cargo, CargoDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<Mascota, MascotaDTO>().ReverseMap();
            CreateMap<Mascota, InsertarMascotaDTO>().ReverseMap();
        }
    }
}
