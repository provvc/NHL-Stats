using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHLStatsAPI.Models;

namespace NHLStatsAPI.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller {

        private readonly HttpClient _httpClient;

        public PlayerController(HttpClient httpClient) {
            _httpClient = httpClient;
        }
        
        [HttpGet("GetPlayer/{playerId}")]
        public async Task<Player> GetPlayer(int playerId) {
            Player player = null;

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/player/{playerId}/landing";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode) {
                string responseData = await response.Content.ReadAsStringAsync();
                player = JsonConvert.DeserializeObject<Player>(responseData);
            }

            return player;
        }

        [HttpGet("GetSeasonRoster/{teamAbbrev}/{season}")]
        public async Task<List<Player>> GetSeasonRoster(string teamAbbrev, int season) {
            var players = new List<Player>();

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/roster/{teamAbbrev}/{season}";

            var response = await _httpClient.GetStringAsync(endpoint);

            var jObject = JObject.Parse(response);

            players = jObject["forwards"].ToObject<List<Player>>();

            return players;
        }
    }
}
