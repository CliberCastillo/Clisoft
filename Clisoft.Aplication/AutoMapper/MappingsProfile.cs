﻿using AutoMapper;
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
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
            CreateMap<Perfil, PerfilDTO>().ReverseMap();
            CreateMap<Empleado, EmpleadoDTO>().ReverseMap();
            CreateMap<Examen, ExamenDTO>().ReverseMap();
            CreateMap<Orden, OrdenDTO>().ReverseMap();
            CreateMap<DetalleOrden, DetalleOrdenDTO>().ReverseMap();
            CreateMap<PerfilExamen, PerfilExamenDTO>().ReverseMap();
        }
    }
}
