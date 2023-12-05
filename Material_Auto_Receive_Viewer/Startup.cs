using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Material_Auto_Receive_Viewer.Middleware;
using Material_Auto_Receive_Viewer.Pages;
using Material_Auto_Receive_Viewer.Pages.Widget;
using Material_Auto_Receive_Viewer.ViewModels;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Material_Auto_Receive_Viewer.Services.Interface;
using Material_Auto_Receive_Viewer.Services.implement;

namespace Material_Auto_Receive_Viewer
{
    public static class Startup
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            Console.WriteLine("ConfigureServices");
            services.AddScoped<ICultureService, CultureService>();

            JsonSerializerSettings DefaultSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.None,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };



            services.AddTransient<IViewModelBase, ViewModelBase>();
            services.AddTransient<Loading>();
            services.AddSingleton<IHttpService, HttpService>();
            services.AddSingleton<IMaterialService, MaterialService>();


            //services.AddSingleton<BaseStateContainer>();
            //services.AddTransient<StateService>();
            //services.AddScoped<IBaseStateContainer, BaseStateContainer>();

            services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();
        }
        public static void Configure(IApplicationBuilder app, IWebAssemblyHostEnvironment env)
        {
            Console.WriteLine("Configure");
            app.UseMiddleware<CultureMiddleware>();
        }
    }
}
