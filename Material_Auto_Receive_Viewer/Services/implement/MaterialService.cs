using Material_Auto_Receive_Viewer.Models;
using Material_Auto_Receive_Viewer.Services.Interface;
using System.Globalization;

namespace Material_Auto_Receive_Viewer.Services.implement
{
    public class MaterialService : IMaterialService
    {
        public IHttpService _httpService;
        public MaterialService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<MaterialReceivePlanMstModel>> GetMaterialReceivePlanMstAsync(DateTime beginDateReceive, DateTime endDateReceive)
        {
            string strbeginDate = beginDateReceive.ToString("yyyy-MM-ddTHH:mm:ss", new CultureInfo("en-US"));
            string strendDate = endDateReceive.ToString("yyyy-MM-ddTHH:mm:ss", new CultureInfo("en-US"));
            string apiurl = "GetMaterialReceivePlanMst?beginDateReceive=" + strbeginDate + "&endDateReceive=" + strendDate + "&siteID=" + 2;
            var data = await _httpService.GetAsync<List<MaterialReceivePlanMstModel>>(apiurl);
            return data;
        }
        public async Task<List<MaterialReceivePlanMstModel>> GetMaterialReceivePlanMstByDocNo(string docNo)
        {
            string apiurl = $"GetMaterialReceivePlanMstByDocNo?siteID=2&docNo={docNo}";
            var data = await _httpService.GetAsync<List<MaterialReceivePlanMstModel>>(apiurl);
            return data;
        }

        public async Task<List<SiteAllModel>> GetSiteAll()
        {
            var url = "GetSiteAll?defaultSite=7";
            var data = await _httpService.GetAsync<List<SiteAllModel>>(url);
            return data;
        }

        public async Task<ErrorLogModel> GetViewLog(DateTime beginDateReceive)
        {
            string strbeginDate = beginDateReceive.ToString("yyyy/MM/dd", new CultureInfo("en-US"));
            //var url = $"GetViewLog?Date={strbeginDate}";
            var url = "Data/LogError.json";
            var data = await _httpService.GetAsync<ErrorLogModel>(url);
            return data;
        }

        public async Task<MaterialReceiveModel> ViewAutoReceiveAllVMAsync(string DocNo, int OwnerSiteId, int ReceiveSiteId)
        {
            var url = $"ViewAutoReceiveAllVM?DocNo_Material_Request_MST={DocNo}&OwnerSiteId={OwnerSiteId}&ReceiveSiteId={ReceiveSiteId}";
            var data = await _httpService.GetAsync<MaterialReceiveModel>(url);
            return data;
        }
    }
}
