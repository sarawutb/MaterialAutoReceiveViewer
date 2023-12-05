using System.Text.Json.Serialization;

namespace Material_Auto_Receive_Viewer.Models
{
    public partial class SiteAllModel
    {
        [JsonPropertyName("siteId")]
        public int SiteId { get; set; }

        [JsonPropertyName("SiteCode")]
        public string SiteCode { get; set; }

        [JsonPropertyName("compId")]
        public string CompId { get; set; }

        [JsonPropertyName("siteNameThai")]
        public string SiteNameThai { get; set; }

        [JsonPropertyName("siteNameEng")]
        public string SiteNameEng { get; set; }

        [JsonPropertyName("siteShortName")]
        public string SiteShortName { get; set; }

        [JsonPropertyName("BusinessTypeID")]
        public string BusinessTypeId { get; set; }

        [JsonPropertyName("AddressThai")]
        public object AddressThai { get; set; }

        [JsonPropertyName("CompNameEng")]
        public object CompNameEng { get; set; }

        [JsonPropertyName("CompNameThai")]
        public object CompNameThai { get; set; }
    }
}
