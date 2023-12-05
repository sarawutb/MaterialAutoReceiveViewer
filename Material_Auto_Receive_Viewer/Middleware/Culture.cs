using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Net.Http;

namespace Material_Auto_Receive_Viewer.Middleware
{
    public interface ICultureService
    {
        void SetCCDateFormat();
    }
    public class CultureService : ICultureService
    {
        public void SetCCDateFormat()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            CultureInfo.CurrentCulture = culture;
            CultureInfo.CurrentUICulture = culture;
        }
    }
    public class CultureMiddleware
    {
        private readonly RequestDelegate _next;

        public CultureMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext context, ICultureService culture)
        {
            culture.SetCCDateFormat();
            return this._next(context);
        }
    }
}
