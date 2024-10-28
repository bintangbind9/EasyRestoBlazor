using Blazored.SessionStorage;
using EasyRestoBlazor.Application.Contracts.Response;
using EasyRestoBlazor.Domain.Enums;

namespace EasyRestoBlazor.Middleware
{
    public class CustomHttpMessageHandler : DelegatingHandler
    {
        private readonly ISessionStorageService _sessionStorageService;

        public CustomHttpMessageHandler(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var auth = await _sessionStorageService.GetItemAsync<AuthResponse>(SessionCode.EasyRestoAuth.ToString());
            if (auth is not null && !string.IsNullOrEmpty(auth.Token))
            {
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", auth.Token);
            }

            var response = await base.SendAsync(request, cancellationToken);

            // Add custom logic after receiving the response
            // For example, logging the response

            return response;
        }
    }
}
