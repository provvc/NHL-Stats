using Newtonsoft.Json;

namespace NHLStatsAPI.Models
{
    public class PlayerSeasonStatistics
    {

        public int playerSeasonStatisticsId { get; set; }

        public int assists { get; set; }

        [JsonProperty("avgToi")]
        public string avgTOI { get; set; }

        [JsonProperty("faceoffWinningPctg")]
        public float faceoffWinningPctg { get; set; }

        [JsonProperty("gameTypeId")]
        public int gameTypeId { get; set; }

        [JsonProperty("gameWinningGoals")]
        public int gameWinningGoals { get; set; }

        [JsonProperty("gamesPlayed")]
        public int gamesPlayed { get; set; }

        [JsonProperty("goals")]
        public int goals { get; set; }

        [JsonProperty("otGoals")]
        public int otGoals { get; set; }

        [JsonProperty("pim")]
        public int pim { get; set; }

        [JsonProperty("plusMinus")]
        public int plusMinus { get; set; }

        [JsonProperty("points")]
        public int points { get; set; }

        [JsonProperty("powerPlayGoals")]
        public int powerPlayGoals { get; set; }

        [JsonProperty("powerPlayPoints")]
        public int powerPlayPoints { get; set; }

        [JsonProperty("season")]
        public int season { get; set; } // season id instead???

        [JsonProperty("shootingPctg")]
        public float shootingPctg { get; set; }

        [JsonProperty("shorthandedGoals")]
        public int shorthandedGoals { get; set; }

        [JsonProperty("shorthandedPoints")]
        public int shorthandedPoints { get; set; }

        [JsonProperty("shots")]
        public int shots { get; set; }

    }
}
