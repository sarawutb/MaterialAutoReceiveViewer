using Material_Auto_Receive_Viewer.Pages;
using Material_Auto_Receive_Viewer.Pages.Widget;
using Material_Auto_Receive_Viewer.Services;
using Material_Auto_Receive_Viewer.ViewModels.implement;

namespace Material_Auto_Receive_Viewer.ViewModels.Imprement;
public static class Dependencies
{
    public static void AddViewModels(this IServiceCollection services)
    {
        services.AddSingleton<IndexViewModel>();
        services.AddSingleton<LoadingViewModel>();
        services.AddScoped<ReceiveDetailViewModel>();
        services.AddScoped<PickingDetailViewModel>();
        services.AddTransient<ErrorLogViewModel>();
    }
}