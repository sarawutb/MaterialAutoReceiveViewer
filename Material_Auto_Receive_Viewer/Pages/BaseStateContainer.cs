using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace Material_Auto_Receive_Viewer.Pages
{
    public interface IBaseStateContainer
    {
        event Action? OnChange;
        bool IsBusy { get; set; }
    }
    public class BaseStateContainer : IBaseStateContainer
    {
        public string? savedString;

        public string Property
        {
            get => savedString ?? string.Empty;
            set
            {
                savedString = value;
                NotifyStateChanged();
            }
        }
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                NotifyStateChanged(nameof(IsBusy));
            }
        }

        public event Action? OnChange;

        protected virtual void NotifyStateChanged([CallerMemberName] string propertyName = null)
        {
            OnChange?.Invoke();
        }
    }
}
