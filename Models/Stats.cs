using System.Text.Json.Serialization;

namespace Models
{
    public class Stats
    {
        [JsonPropertyName("TotalConfirmed")]
        public long Confirmed { get; set; }

        [JsonPropertyName("TotalDeaths")]
        public long Deaths { get; set; }

        [JsonPropertyName("TotalRecovered")]
        public long Recovered { get; set; }
    }
}