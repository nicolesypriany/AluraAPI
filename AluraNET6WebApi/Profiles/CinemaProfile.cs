using AluraNET6WebApi.Data.Dtos;
using AluraNET6WebApi.Models;
using AutoMapper;

namespace AluraNET6WebApi.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>();
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}
