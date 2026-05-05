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

        public virtual ICollection<TeamSeasonStatistics> TeamSeasonStatistics { get; set; }
        public virtual ICollection<TeamGameStatistics> TeamGameStatistics { get; set; }

    }
}
