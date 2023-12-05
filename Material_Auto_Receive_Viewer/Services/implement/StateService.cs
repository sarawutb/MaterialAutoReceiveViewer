namespace Material_Auto_Receive_Viewer.Services.implement
{
    public class StateService
    {
        public event EventHandler? CounterChanged;

        private int _currentCount;
        public int CurrentCount
        {
            get => _currentCount;
            set
            {
                _currentCount = value;
                CounterChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
