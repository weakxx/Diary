using ASProject.Application.Mapping;
using AutoMapper;

namespace ASProject.Tests.Configurations;

public class MapperConfiguration
{
    public static IMapper GetMapperConfiguration()
    {
        var mockMapper = new AutoMapper.MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new ReportMapping());
        });
        return mockMapper.CreateMapper();
    }
}