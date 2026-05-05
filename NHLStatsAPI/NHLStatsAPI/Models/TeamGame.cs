namespace NHLStatsAPI.Models {
    public class TeamGame {
        public int teamId { get; set; }
        public int gameId { get; set; }

        public virtual Team Team { get; set; }
        public virtual Game Game { get; set; }
    }
}
