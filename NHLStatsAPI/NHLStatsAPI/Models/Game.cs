using Newtonsoft.Json;

namespace NHLStatsAPI.Models {
    public class Game {

        public int gameId { get; set; }
        public int seasonId { get; set; }
        public int awayTeamId { get; set; } // need an away team indentifier
        public int homeTeamId { get; set; } // need a home team identifier
        
        [JsonProperty("gameType")]
        public int gameTypeId { get; set; }
        
        [JsonProperty("startTimeUTC")]
        public DateTime gameTime { get; set; }

        public virtual ICollection<PlayerGameStatistics> PlayerGameStatistics { get; set; }
        public virtual ICollection<TeamGameStatistics> TeamGameStatistics { get; set; }

    }
}
