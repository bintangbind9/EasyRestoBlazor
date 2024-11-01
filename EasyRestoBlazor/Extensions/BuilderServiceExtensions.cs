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
            services.AddTransient<IBaseRepository<CreateAppUserRequest, UpdateAppUserRequest, AppUserResponse>, AppUserRepository>();
            services.AddTransient<IBaseRepository<CreateRoleRequest, UpdateRoleRequest, RoleResponse>, RoleRepository>();
            services.AddTransient<IBaseRepository<CreatePrivilegeRequest, UpdatePrivilegeRequest, PrivilegeResponse>, PrivilegeRepository>();
            services.AddTransient<IBaseRepository<CreateFoodItemRequest, UpdateFoodItemRequest, FoodItemResponse>, FoodItemRepository>();
            services.AddTransient<IBaseRepository<CreateFoodItemStatusRequest, UpdateFoodItemStatusRequest, FoodItemStatusResponse>, FoodItemStatusRepository>();
            services.AddTransient<IBaseRepository<CreateOrderRequest, UpdateOrderRequest, OrderResponse>, OrderRepository>();
            services.AddTransient<IBaseRepository<CreateOrderStatusRequest, UpdateOrderStatusRequest, OrderStatusResponse>, OrderStatusRepository>();

            return services;
        }
    }
}
