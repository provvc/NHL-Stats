using System.Numerics;

namespace NHLStatsAPI.Models {
    public class TeamSeason {
        public int teamId { get; set; }
        public int seasonId { get; set; }
        public int conferenceId { get; set; }
        public int divisionId { get; set; }

        public string logoURL { get; set; }

        // not sure if I need these below or not...
        public virtual Team Team { get; set; }
        public virtual Season Season { get; set; }
        public virtual Conference Conference { get; set; } // not sure if this is actually needed; we'll see I guess
        public virtual Division Division { get; set; } // not sure if this is actually needed; we'll see I guess
    }
}
