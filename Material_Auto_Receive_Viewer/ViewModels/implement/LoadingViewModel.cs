using Material_Auto_Receive_Viewer.Pages.Widget;
using Material_Auto_Receive_Viewer.Services;

namespace Material_Auto_Receive_Viewer.ViewModels.Imprement
{
    public class LoadingViewModel : ViewModelBase
    {
        public LoadingViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public bool _IsLoading;
        public bool IsLoading
        {
            get => _IsLoading;
            set
            {
                _IsLoading = value;
                NotifyStateChanged();
            }
        }
    }
}
