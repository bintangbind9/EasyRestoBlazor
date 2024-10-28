using Blazored.SessionStorage;
using EasyRestoBlazor.Application.Contracts.Request;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Application.Repository;
using EasyRestoBlazor.Domain.Enums;
using System.Net.Http.Json;

namespace EasyRestoBlazor.Infrastructure.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ISessionStorageService _sessionStorageService;
        private readonly HttpClient _http;

        public AuthRepository(ISessionStorageService sessionStorageService, HttpClient http)
        {
            _sessionStorageService = sessionStorageService;
            _http = http;
        }

        public async Task<bool> IsLogin()
        {
            return await _sessionStorageService.ContainKeyAsync(SessionCode.EasyRestoAuth.ToString());
        }

        public async Task<AuthResponse?> GetUser()
        {
            return await _sessionStorageService.GetItemAsync<AuthResponse>(SessionCode.EasyRestoAuth.ToString());
        }

        public async Task<BaseResponse<AuthResponse>> Login(AuthLoginRequest request)
        {
            var jsonContent = JsonContent.Create(request);
            var response = await _http.PostAsync("api/Auth/Login", jsonContent);

            var baseResponse = await response.Content.ReadFromJsonAsync<BaseResponse<AuthResponse>>();

            if (baseResponse.Status != 200)
            {
                throw new Exception(baseResponse.Errors.Any() ? baseResponse.Errors[0] : "Failed Login!");
            }

            return baseResponse;
        }

        public async Task Logout()
        {
            await _sessionStorageService.RemoveItemAsync(SessionCode.EasyRestoAuth.ToString());
        }
    }
}
