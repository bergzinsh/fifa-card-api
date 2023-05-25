using FifaCardApi.Domain.Context;
using FifaCardApi.Repository.Repository;
using FifaCardApi.Repository.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace FifaCardApi.Repository.IoC
{
    public static class RepositoryServiceCollection
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<ICardRepository, CardRepository>();
        }

        public static void AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<PlayerContext>(options =>
            {
                var configuration = services.BuildServiceProvider().GetService<IConfiguration>();
                options.UseSqlServer(configuration.GetConnectionString("DEV_SQL_CONNECTION_STRING"));
            });
        }
    }
}
