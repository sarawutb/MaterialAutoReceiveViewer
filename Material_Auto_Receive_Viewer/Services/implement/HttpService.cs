using System.Text.Json;
using Material_Auto_Receive_Viewer.Services.Interface;
using Material_Auto_Receive_Viewer.ViewModels;
using RestSharp;
using RestSharp.Serializers.Json;

namespace Material_Auto_Receive_Viewer.Services.implement
{
    public class HttpService : IHttpService
    {
        private readonly string BaseUrl = "http://localhost:7290";
        private RestClient _restClient;
        private ViewModelBase _viewModelBase;
        public HttpService(RestClient restClient, ViewModelBase viewModelBase)
        {
            _viewModelBase = viewModelBase;
            _restClient = restClient;
            //    new RestClient(
            // new HttpClient { BaseAddress = new Uri(BaseUrl) },
            //configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions
            //{
            //    PropertyNamingPolicy = null,
            //    PropertyNameCaseInsensitive = true,
            //})
            //);
        }
        public async Task<T> GetAsync<T>(string url)
        {
            try
            {
                _viewModelBase.IsBusy = true;
                await Task.Delay(1000);
                //var Url = string.Format("{0}/{1}", BaseUrl, url);
                //var Data = await _restClient.GetJsonAsync<T>(Url);
                var request = new RestRequest(url);
                //Console.WriteLine(Url);
                var response = await _restClient.ExecuteGetAsync<T>(request);
                if (response.ErrorException != null)
                {
                    _viewModelBase.IsBusy = false;
                    return default;
                }
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    Console.WriteLine(response.Content);
                    var Data = response.Data;
                    _viewModelBase.IsBusy = false;
                    return Data;
                }
                else
                {
                    throw new Exception(response.ErrorMessage);
                }
                //Console.WriteLine(Url);
                //var client = new RestClient(Url);
                //var request = new RestRequest(Url, Method.Get);
                //RestResponse response = await client.ExecuteAsync(request);
                //var Output = response.Content;
                //Console.WriteLine(Output);
                //var Data = JsonConvert.DeserializeObject<T>(Output);
                //return Data;
            }
            catch (Exception ex)
            {
                _viewModelBase.IsBusy = false;
                Console.WriteLine(ex);
                throw ex;
            }
        }
    }
}
