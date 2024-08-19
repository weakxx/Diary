using ASProject.Producer.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ASProject.Producer.DependencyInjection;

public static class DependencyInjection
{
    public static void AddProducer(this IServiceCollection services)
    {
        services.AddScoped<IMessageProducer, Producer>();
    }
}