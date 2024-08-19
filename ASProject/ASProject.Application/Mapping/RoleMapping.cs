using ASProject.Domain.Dto.Role;
using ASProject.Domain.Entity;
using AutoMapper;

namespace ASProject.Application.Mapping;

public class RoleMapping : Profile
{
    public RoleMapping()
    {
        CreateMap<Role, RoleDto>().ReverseMap();
    }
}