using FifaCardApi.Service.Services;
using FifaCardApi.Service.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FifaCardApi.Service.IoC
{
    public static class CoreServiceCollection
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<ICardService, CardService>();
        }
    }
}