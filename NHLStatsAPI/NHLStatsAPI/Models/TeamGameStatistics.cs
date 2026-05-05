namespace NHLStatsAPI.Models {
    public class TeamGameStatistics {
        public int teamGameStatisticsId { get; set; }
        public int gameId { get; set; }
        public int teamId { get; set; }

        public int powerPlayGoals { get; set; }
        public int powerPlayOpportunities { get; set; }
        public int faceoffWins { get; set; }
        public int faceoffAttempts { get; set; }

        public virtual Game Game { get; set; }
        public virtual Team Team { get; set; }
    }
}
