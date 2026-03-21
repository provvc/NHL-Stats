using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHLStatsAPI.Models;

namespace NHLStatsAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PlayerSeasonStatisticsController : Controller {
        
        private readonly HttpClient _httpClient;

        public PlayerSeasonStatisticsController(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        [HttpGet(Name = "GetPlayerSeasonTotals")]
        public async Task<IEnumerable<PlayerSeasonStatistics>> GetPlayerSeasonTotals(int playerId) {

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/player/{playerId}/landing";

            var response = await _httpClient.GetStringAsync(endpoint);

            var jObject = JObject.Parse(response);

            var seasonTotals = jObject["seasonTotals"].Where(t => t["leagueAbbrev"].Value<string>() == "NHL").Select(t => t.ToObject<PlayerSeasonStatistics>()).ToList();

            return seasonTotals;

        }

    }
}
