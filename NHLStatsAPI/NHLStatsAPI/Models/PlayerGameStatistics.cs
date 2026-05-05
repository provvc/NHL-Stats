namespace NHLStatsAPI.Models {
    public class PlayerGameStatistics {
        public int playerGameStatisticsId { get; set; }
        public int playerId { get; set; }
        public int gameId { get; set; }
        public int teamId { get; set; }

        public int goals { get; set; }
        public int assists { get; set; }
        public int points { get; set; }
        public int plusMinus { get; set; }
        public int pim { get; set; }
        public int hits { get; set; }
        public int powerPlayGoals { get; set; }
        public int sog { get; set; }
        public float faceoffWinningPctg { get; set; }
        public string toi { get; set; }
        public int blockedShots { get; set; }
        public int shifts { get; set; }
        public int giveaways { get; set; }
        public int takeaways { get; set; }

        public virtual Player Player { get; set; }
        public virtual Game Game { get; set; }
        public virtual Team Team { get; set; }


        public PlayerGameStatistics() { }

    }
}
