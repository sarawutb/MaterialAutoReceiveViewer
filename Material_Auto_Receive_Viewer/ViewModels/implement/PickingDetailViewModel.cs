using Material_Auto_Receive_Viewer.Services.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Material_Auto_Receive_Viewer.ViewModels.Imprement
{
    public class PickingDetailViewModel : ViewModelBase
    {
        private IHttpService _httpService;
        private IJSRuntime _JS;
        public PickingDetailViewModel(IHttpService httpService, IJSRuntime jSRuntime, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _httpService = httpService;
            _JS = jSRuntime;
        }

        [Parameter]
        public string DocNo { get; set; }
    }
}
