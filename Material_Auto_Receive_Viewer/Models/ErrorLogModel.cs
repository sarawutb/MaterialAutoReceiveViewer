using System.Text.Json.Serialization;

namespace Material_Auto_Receive_Viewer.Models
{
    public partial class ErrorLogModel
    {
        [JsonPropertyName("Log File")]
        public string LogFile { get; set; }

        [JsonPropertyName("Detail Log")]
        public List<DetailLog> DetailLog { get; set; }
    }

    public partial class DetailLog
    {
        [JsonPropertyName("DateTime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonPropertyName("URLRequest")]
        public string UrlRequest { get; set; }

        [JsonPropertyName("ApiData")]
        public string ApiData { get; set; }
    }
}
