using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace NHLStatsAPI.Models {
    public class GoalieGameStatistics {
        public int goalieGameStatisticsId { get; set; }
        public int gameId { get; set; }
        public int goalieId { get; set; }
        public int teamId { get; set; }

        public int evenStrengthShotsAgainst { get; set; }
        public int powerPlayShotsAgainst { get; set; }
        public int shorthandedShotsAgainst { get; set; }
        public int savedShotsAgainst { get; set; }
        public float savePctg { get; set; }
        public int evenStrengthGoalsAgainst { get; set; }
        public int powerPlayGoalsAgainst { get; set; }
        public int shorthandedGoalsAgainst { get; set; }
        public int pim { get; set; } // revisit the datatype
        public int goalsAgainst { get; set; }
        public string toi { get; set; } // revisit the datatype
        public bool starter { get; set; } // revisit the datatype
        public int decision { get; set; } // what in the world is this property
        public int shotsAgainst { get; set; }
        public int saves { get; set; }

        public virtual Game Game { get; set; }
        public virtual Goalie Goalie { get; set; }
        public virtual Team Team { get; set; }
    }
}
