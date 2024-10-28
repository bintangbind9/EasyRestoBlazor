using EasyRestoBlazor.Application.Repository;
using EasyRestoBlazor.Infrastructure.Repository;

namespace EasyRestoBlazor.Extensions
{
    public static class BuilderServiceExtensions
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddTransient<IAuthRepository, AuthRepository>();

            return services;
        }
    }
}
