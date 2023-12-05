using Material_Auto_Receive_Viewer.Models;
using Material_Auto_Receive_Viewer.Pages;
using Material_Auto_Receive_Viewer.Services.Interface;
using Material_Auto_Receive_Viewer.ViewModels.Interface;
using Microsoft.JSInterop;
using System;
using System.Globalization;

namespace Material_Auto_Receive_Viewer.ViewModels.Imprement
{
    public class IndexViewModel : ViewModelBase, IIndexViewModel
    {
        private IMaterialService _materialService;
        private IJSRuntime _JS;
        public IndexViewModel(IMaterialService materialService, IJSRuntime jSRuntime, IServiceProvider serviceProvider) : base(serviceProvider)
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
        private DateTime _DateEnd { get; set; } = DateTime.Now;
        public DateTime DateEnd
        {
            get => _DateEnd;
            set
            {
                _DateEnd = value;
            }
        }
        private string _DocNoSearch = string.Empty;
        public string DocNoSearch
        {
            get => _DocNoSearch;
            set
            {
                _DocNoSearch = value;
                NotifyStateChanged();
            }
        }
        private List<MaterialReceivePlanMstModel> _MaterialReceivePlanMstData = new List<MaterialReceivePlanMstModel>();
        public List<MaterialReceivePlanMstModel> MaterialReceivePlanMstData
        {
            get => _MaterialReceivePlanMstData;
            set
            {
                if (value == null)
                {
                    value = new List<MaterialReceivePlanMstModel>();
                }
                _MaterialReceivePlanMstData.Clear();
                _MaterialReceivePlanMstData = value;
                NotifyStateChanged();
            }
        }

        public async Task GetMaterialReceivePlanMstAsync(DateTime beginDateReceive, DateTime endDateReceive)
        {
            if (string.IsNullOrEmpty(DocNoSearch))
            {
                MaterialReceivePlanMstData = await _materialService.GetMaterialReceivePlanMstAsync(beginDateReceive, endDateReceive);
            }
            else
            {
                MaterialReceivePlanMstData = await _materialService.GetMaterialReceivePlanMstByDocNo(DocNoSearch);
            }
        }
    }
}
