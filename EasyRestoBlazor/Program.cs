using Blazored.SessionStorage;
using EasyRestoBlazor;
using EasyRestoBlazor.Extensions;
using EasyRestoBlazor.Middleware;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredSessionStorage();
builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.TopRight;
    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = true;
});

builder.Services.AddScoped<HttpClient>(sp =>
{
    var sessionStorageService = sp.GetRequiredService<ISessionStorageService>();

    var handler = new CustomHttpMessageHandler(sessionStorageService)
    {
        InnerHandler = new HttpClientHandler()
    };

    return new HttpClient(handler) { BaseAddress = new Uri(builder.Configuration["EasyRestoWebApiBaseURL"]!) };
});

builder.Services.AddAppDI();

await builder.Build().RunAsync();
