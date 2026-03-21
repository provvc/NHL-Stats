using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace NHLStatsAPI.Models {
    public class Team {

        [JsonProperty("id")]
        public int teamId { get; set; }

        [JsonProperty("franchiseId")]
        public int? franchiseId { get; set; }

        [JsonProperty("triCode")]
        public string abbrev { get; set; }

        [JsonProperty("fullName")]
        public string name { get; set; }

        //public string logoURL { get; set; }

        //public int active { get; set; }

    }
}
