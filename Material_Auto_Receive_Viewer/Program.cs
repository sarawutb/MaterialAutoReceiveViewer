using Blazorise;
using Blazorise.Bootstrap;
using Material_Auto_Receive_Viewer;
using Material_Auto_Receive_Viewer.Pages;
using Material_Auto_Receive_Viewer.ViewModels;
using Material_Auto_Receive_Viewer.ViewModels.Imprement;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RestSharp;
using RestSharp.Serializers.Json;
using System.Text.Json;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#AppStart");
        builder.RootComponents.Add<HeadOutlet>("head::after");

        builder.Services.AddSingleton<ViewModelBase>();
        builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

        builder.Services.AddSingleton(new RestClient(
             new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) },
            configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
            })));
        //builder.Services.AddSingleton<BaseStateContainer>();

        builder.Services.ConfigureServices();
        builder.Services.AddViewModels();

        await builder.Build().RunAsync();
    }
}

