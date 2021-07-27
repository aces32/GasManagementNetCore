using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MonitorGas.GasManagement.App.Contracts;
using MonitorGas.GasManagement.App.Services;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace MonitorGas.GasManagement.App
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

                    

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddOidcAuthentication(options =>
            {
                builder.Configuration.Bind("Auth0", options.ProviderOptions);
                options.ProviderOptions.ResponseType = "code";
            });

            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredSessionStorage();
            builder.Services.AddSingleton(new HttpClient
            {
                BaseAddress = new Uri("https://localhost:44339")
            });

            builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("https://localhost:44339"))
                .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
            builder.Services.AddScoped<IGasSizeDataService, GasSizesDataService>();
            builder.Services.AddScoped<IGasDataService, GasDataService>();
            builder.Services.AddScoped<IOrderDataService, OrderDataService>();

            builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>()
            .CreateClient("https://localhost:44339"));

            await builder.Build().RunAsync();

        }
    }
}
