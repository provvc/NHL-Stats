namespace NHLStatsAPI.Models {
    public class GoalieSeasonStatistics {
        public int goalieSeasonStatisticsId { get; set; }
        public int goalieId { get; set; }
        public int seasonId { get; set; }
        public int teamId { get; set; }

        public int assists { get; set; }
        public int gamesPlayed { get; set; }
        public int gamesStarted { get; set; }
        public int goals { get; set; }
        public int goalsAgainst { get; set; }
        public float goalsAgainstAvg { get; set; } // check the datatype on this one
        public int losses { get; set; }
        public int otLosses { get; set; }
        public int pim { get; set; }
        public float savePctg { get; set; } // check the datatype on this one
        public int shotsAgainst { get; set; }
        public int shutouts { get; set; }
        public string timeOnIce { get; set; } // check the datatype of this one
        public int wins { get; set; }

        public virtual Goalie Goalie { get; set; }
        public virtual Season Season { get; set; }
        public virtual Team Team { get; set; }
    }
}
