using Material_Auto_Receive_Viewer.Models;

namespace Material_Auto_Receive_Viewer.Services.Interface
{
    public interface IMaterialService
    {
        Task<List<MaterialReceivePlanMstModel>> GetMaterialReceivePlanMstAsync(DateTime beginDateReceive, DateTime endDateReceive);
        Task<List<MaterialReceivePlanMstModel>> GetMaterialReceivePlanMstByDocNo(string docNo);
        Task<MaterialReceiveModel> ViewAutoReceiveAllVMAsync(string DocNo, int OwnerSiteId, int ReceiveSiteId);
        Task<List<SiteAllModel>> GetSiteAll();
        Task<ErrorLogModel> GetViewLog(DateTime beginDateReceive);
    }
}
