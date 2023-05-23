using FifaCardApi.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FifaCardApi.Service.IoC
{
    public static class CoreServicesCollection
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddSingleton<ICardService, CardService>();
        } 
    }
}