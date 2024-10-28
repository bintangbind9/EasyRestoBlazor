using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;

namespace EasyRestoBlazor.Application.Repository
{
    public interface IAuthRepository
    {
        public Task<bool> IsLogin();

        public Task<AuthResponse?> GetUser();

        public Task<BaseResponse<AuthResponse>> Login(AuthLoginRequest request);

        public Task Logout();
    }
}
