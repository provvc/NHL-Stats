using Newtonsoft.Json;
using System.Text.Json;

namespace NHLStatsAPI.Models {
    public class Player {

        public int playerId { get; set; }
        public int skaterId { get; set; }

        public virtual Skater Skater { get; set; } // keyword 'virtual' makes it overrideable???
        public virtual ICollection<PlayerSeasonStatistics> PlayerSeasonStatistics { get; set; }
        public virtual ICollection<PlayerGameStatistics> PlayerGameStatistics { get; set; }

    }


}
