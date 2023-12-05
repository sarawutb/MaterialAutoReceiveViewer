using Material_Auto_Receive_Viewer.Models;
using Material_Auto_Receive_Viewer.Services.Interface;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Material_Auto_Receive_Viewer.ViewModels.Imprement
{
    public class ReceiveDetailViewModel : ViewModelBase
    {
        private IMaterialService _materialService;
        private IJSRuntime _JS;
        public ReceiveDetailViewModel(IMaterialService materialService, IJSRuntime jSRuntime, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _JS = jSRuntime;
            _materialService = materialService;
        }

        public string DocNo { get; set; }
        public int OwnerSiteId { get; set; }
        public int ReceiveSiteId { get; set; }
        private MaterialReceiveModel _MaterialReceiveModel = new MaterialReceiveModel();
        public MaterialReceiveModel MaterialReceiveModel
        {
            get => _MaterialReceiveModel;
            set
            {
                if (value == null)
                {
                    value = new MaterialReceiveModel(); ;
                }
                _MaterialReceiveModel = value;
                NotifyStateChanged();
            }
        }

        public async Task LoadReceiveDetail()
        {
            MaterialReceiveModel = await _materialService.ViewAutoReceiveAllVMAsync(DocNo, OwnerSiteId, ReceiveSiteId);
        }
    }
}
