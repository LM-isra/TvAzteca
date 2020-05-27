using TvAzteca.Core.Entities;
using TvAzteca.Api.Models;
using AutoMapper;

namespace TvAzteca.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();
        }
    }
}
