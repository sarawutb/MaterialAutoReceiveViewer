using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Material_Auto_Receive_Viewer.Pages.Widget;
using Material_Auto_Receive_Viewer.ViewModels.Imprement;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using System.ComponentModel;

namespace Material_Auto_Receive_Viewer.ViewModels
{
    public interface IViewModelBase : INotifyPropertyChanged
    {
        Task OnInitializedAsync();
        Task Loaded();
        bool IsBusy { get; set; }
    }
    public partial class ViewModelBase : ObservableObject, IViewModelBase
    {
        private readonly IServiceProvider _serviceProvider;
        public ViewModelBase(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        private bool _isBusy = false;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                //_Loading.IsLoading = value;
                var Loading = _serviceProvider.GetService(typeof(LoadingViewModel)) as LoadingViewModel;
                Loading.IsLoading = value;
                OnPropertyChanged(nameof(Loading));
                OnPropertyChanged(nameof(IsBusy));
            }
        }
        public virtual async Task OnInitializedAsync()
        {
            await Loaded().ConfigureAwait(true);
        }

        protected virtual void NotifyStateChanged() => OnPropertyChanged((string?)null);

        [RelayCommand]
        public virtual async Task Loaded()
        {
            await Task.CompletedTask.ConfigureAwait(false);
        }
    }
    //public abstract class BaseViewModel : INotifyPropertyChanged
    //{
    //    private bool isBusy = false;
    //    public bool IsBusy
    //    {
    //        get => isBusy;
    //        set
    //        {
    //            SetValue(ref isBusy, value);
    //        }
    //    }

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    //    {

    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //    protected void SetValue<T>(ref T backingFiled, T value, [CallerMemberName] string propertyName = null)
    //    {
    //        if (EqualityComparer<T>.Default.Equals(backingFiled, value)) return;
    //        backingFiled = value;
    //        OnPropertyChanged(propertyName);
    //    }
    //}

}
