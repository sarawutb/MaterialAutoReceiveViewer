using Material_Auto_Receive_Viewer.Models;
using Material_Auto_Receive_Viewer.Pages;

namespace Material_Auto_Receive_Viewer.ViewModels.Interface
{
    public interface IIndexViewModel
    {
        DateTime DateStart { get; set; }
        DateTime DateEnd { get; set; }
        string DocNoSearch { get; set; }
        List<MaterialReceivePlanMstModel> MaterialReceivePlanMstData { get; set; }
        //Task GetMaterialReceivePlanMstAsync(DateTime beginDateReceive, DateTime endDateReceive);
    }
}
