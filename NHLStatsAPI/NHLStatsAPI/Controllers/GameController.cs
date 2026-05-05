using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHLStatsAPI.Models;

namespace NHLStatsAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase {

        private readonly HttpClient _httpClient;

        public GameController(HttpClient httpClient) { 
            _httpClient = httpClient;
        }

        [HttpGet("boxscore/{gameId}/away")]
        public async Task<List<PlayerGameStatistics>> GetGameBoxScoreAway(int gameId) {

            var boxscoreAway = new List<PlayerGameStatistics>();

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/gamecenter/{gameId}/boxscore";

            var response = await _httpClient.GetStringAsync(endpoint);

            var jObject = JObject.Parse(response);

            boxscoreAway = jObject["playerByGameStats"]["awayTeam"]["forwards"].ToObject<List<PlayerGameStatistics>>();

            return boxscoreAway;

        }

        [HttpGet("boxscores/{gameId}/home")]
        public async Task<List<PlayerGameStatistics>> GetGameBoxScoreHome(int gameId) {

            var boxscoreHome = new List<PlayerGameStatistics>();

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/gamecenter/{gameId}/boxscore";

            var response = await _httpClient.GetStringAsync(endpoint);

            var jObject = JObject.Parse(response);

            boxscoreHome = jObject["playerByGameStats"]["homeTeam"]["forwards"].ToObject<List<PlayerGameStatistics>>();

            return boxscoreHome;

        }

        [HttpGet("game/{gameId}")]
        public async Task<Game> GetGameInformation(int gameId) {
            var game = new Game();

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/gamecenter/{gameId}/boxscore";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode) {
                string responseData = await response.Content.ReadAsStringAsync();
                game = JsonConvert.DeserializeObject<Game>(responseData);
            }

            return game;

        }


    }
}
