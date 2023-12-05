namespace Material_Auto_Receive_Viewer.Services.Interface
{
    public interface IHttpService
    {
        public Task<T> GetAsync<T>(string url);
    }
}
