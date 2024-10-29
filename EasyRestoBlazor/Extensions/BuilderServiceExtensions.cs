using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using EasyRestoBlazor.Infrastructure.Repository;

namespace EasyRestoBlazor.Extensions
{
    public static class BuilderServiceExtensions
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IBaseRepository<CreateFoodCategoryRequest, UpdateFoodCategoryRequest, FoodCategoryResponse>, FoodCategoryRepository>();
            services.AddTransient<IBaseRepository<CreateDiningTableRequest, UpdateDiningTableRequest, DiningTableResponse>, DiningTableRepository>();

            return services;
        }
    }
}
