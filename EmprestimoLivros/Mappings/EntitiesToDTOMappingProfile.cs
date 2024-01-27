using AutoMapper;
using EmprestimoLivros.DTO;
using EmprestimoLivros.Models;

namespace EmprestimoLivros.Mappings
{
    public class EntitiesToDTOMappingProfile : Profile
    {
        public EntitiesToDTOMappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>().ReverseMap();
        }
    }
}
