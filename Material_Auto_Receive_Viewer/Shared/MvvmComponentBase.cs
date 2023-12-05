﻿using Material_Auto_Receive_Viewer.ViewModels;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;

namespace Material_Auto_Receive_Viewer.Shared
{
    public abstract class MvvmComponentBase<TViewModel> : ComponentBase
     where TViewModel : IViewModelBase
    {
        [Inject]
        [NotNull]
#pragma warning disable CS8618
        protected TViewModel ViewModel { get; set; }
#pragma warning restore CS8618

        protected override void OnInitialized()
        {
            ViewModel.PropertyChanged += (_, _) => StateHasChanged();
            base.OnInitialized();
        }

        protected override Task OnInitializedAsync()
        {
            return ViewModel.OnInitializedAsync();
        }
    }
}
