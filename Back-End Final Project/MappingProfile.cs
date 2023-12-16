using AutoMapper;
using Back_End_Final_Project.Models;
using Back_End_Final_Project.Models.DTOS;
namespace Back_End_Final_Project
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Game, GamesDTO>();
            CreateMap<User, UsersDTO>();
            CreateMap<CreateUserDTO, User>();
        }
    }
}
