using Material_Auto_Receive_Viewer.Models;
using Material_Auto_Receive_Viewer.Pages;
using Material_Auto_Receive_Viewer.Services.Interface;
using Microsoft.JSInterop;

namespace Material_Auto_Receive_Viewer.ViewModels.implement
{
    public class ErrorLogViewModel : ViewModelBase
    {
        private readonly IMaterialService _materialService;
        private readonly IJSRuntime _JS;
        public ErrorLogViewModel(IMaterialService materialService, IJSRuntime jSRuntime, IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _materialService = materialService;
            _JS = jSRuntime;
        }

        private DateTime _DateStart { get; set; } = DateTime.Now;
        public DateTime DateStart
        {
            get => _DateStart;
            set
            {
                _DateStart = value;
            }
        }

        private ErrorLogModel _ErrorLog;
        public ErrorLogModel ErrorLog
        {
            get => _ErrorLog; set
            {
                _ErrorLog = value;
                NotifyStateChanged();
            }
        }
        public async Task GetViewLog()
        {
            ErrorLog = await _materialService.GetViewLog(DateStart);
        }
    }
}
