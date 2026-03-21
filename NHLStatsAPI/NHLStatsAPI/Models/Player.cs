using Newtonsoft.Json;
using System.Text.Json;

namespace NHLStatsAPI.Models {
    public class Player {

        [JsonProperty("id")] // roster seeding takes "id", player landing seeding takes "playerId"
        public int playerId { get; set; }

        [JsonProperty("currentTeamId")]
        public int currentTeamId { get; set; }

        [JsonProperty("firstName")]
        public NameObject firstName { get; set; } // Name Object

        [JsonProperty("lastName")]
        public NameObject lastName { get; set; } // Name Object

        [JsonProperty("headshot")]
        public string headshot { get; set; }

        [JsonProperty("heightInInches")]
        public int heightInInches { get; set; }

        [JsonProperty("weightInPounds")]
        public int weightInPounds { get; set; }

        [JsonProperty("sweaterNumber")]
        public int sweaterNumber { get; set; }

        [JsonProperty("position")]
        public string position { get; set; }

        [JsonProperty("birthDate")]
        public DateTime birthDate { get; set; }

        [JsonProperty("birthCountry")]
        public string birthCountry { get; set; }

        [JsonProperty("birthStateProvince")]
        public NameObject birthStateProvince { get; set; } // name object

        [JsonProperty("birthCity")]
        public NameObject birthCity { get; set; } // name object

        [JsonProperty("shootsCatches")]
        public string handedness { get; set; }

    }

    public class NameObject {
        [JsonProperty("default")]
        public string Default { get; set; }
    }
}
