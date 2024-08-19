using ASProject.Domain.Dto.User;
using ASProject.Domain.Entity;
using AutoMapper;

namespace ASProject.Application.Mapping;

public class UserMapping : Profile
{
    public UserMapping()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}