namespace NHLStatsAPI.Models {
    public class Goalie {

        public int goalieId { get; set; }
        public int skaterId { get; set; }

        public virtual Skater Skater { get; set; } // keyword 'virtual' makes it overrideable???
        public virtual ICollection<GoalieSeasonStatistics> GoalieSeasonStatistics { get; set; }
        public virtual ICollection<GoalieGameStatistics> GoalieGameStatistics { get; set; }
    }
}
