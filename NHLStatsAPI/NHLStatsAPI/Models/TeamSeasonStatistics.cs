namespace NHLStatsAPI.Models {
    public class TeamSeasonStatistics {
        public int teamSeasonStatisticsId { get; set; }
        public int teamId { get; set; }
        public int seasonId { get; set; }
        public int gameTypeId { get; set; }

        public int gamesPlayed { get; set; }
        public int goalsDifferential { get; set; }
        public int goalsAgainst { get; set; }
        public int goalsFor { get; set; }
        public int homeGoalsDifferential { get; set; } // don't think this is very needed, can be derived from proceeding properties
        public int homeGoalsAgainst { get; set; }
        public int homeGoalsFor { get; set; }
        public int homeLosses { get; set; }
        public int homeOTLosses { get; set; }
        public int homePoints { get; set; }
        public int homeRegulationWins { get; set; }
        public int homeTies { get; set; }
        public int homeWins { get; set; }
        public int losses { get; set; }
        public int otLosses { get; set; }
        public float pointPctg { get; set; } // revisit the datatype
        public int points { get; set; }
        public int regulationWins { get; set; }
        public int roadGoalsDifferential { get; set; } // don't think this is very need, can be derived from proceeding properties
        public int roadGoalsAgainst { get; set; }
        public int roadGoalsFor { get; set; }
        public int roadLosses { get; set; }
        public int roadPoints { get; set; }
        public int roadTies { get; set; }
        public int roadRegulationWins { get; set; }
        public int shootoutLosses { get; set; }
        public int ties { get; set; }
        public float winPctg { get; set; }  // revisit the datatype
        public int wins { get; set; }

        public virtual Team Team { get; set; }
        public virtual Season Season { get; set; }
        public virtual GameType GameType { get; set; } // not sure if this is needed or not
    }
}
