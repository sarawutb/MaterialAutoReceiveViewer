using Material_Auto_Receive_Viewer.Services.implement;
using Microsoft.AspNetCore.Components;

namespace Material_Auto_Receive_Viewer.Pages
{
    public class MyComponentBase : ComponentBase, IDisposable
    {
        [Inject] private StateService Service { get; set; } = default!;

        private bool _firstRender = true;
        public override Task SetParametersAsync(ParameterView parameters)
        {
            parameters.SetParameterProperties(this);
            if (_firstRender)
                this.Service.CounterChanged += this.OnStateChanged;

            _firstRender = false;
            return base.SetParametersAsync(ParameterView.Empty);
        }

        private void OnStateChanged(object? sender, EventArgs e)
        => this.InvokeAsync(StateHasChanged);

        public virtual void Dispose()
            => this.Service.CounterChanged -= this.OnStateChanged;
    }
}
