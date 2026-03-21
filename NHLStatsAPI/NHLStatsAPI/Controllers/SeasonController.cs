using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NHLStatsAPI.Models;

namespace NHLStatsAPI.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class SeasonController : ControllerBase {

        private readonly HttpClient _httpClient;

        public SeasonController(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        [HttpGet(Name = "GetTeamSeasons")]
        public async Task<IEnumerable<Season>> GetTeamSeasons(string teamAbbrev) {

            var seasons = new List<Season>();
            List<int> seasonsList = null;

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api-web.nhle.com/v1/roster-season/{teamAbbrev}";


            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            if (response.IsSuccessStatusCode) {

                string responseData = await response.Content.ReadAsStringAsync();

                seasonsList = JsonConvert.DeserializeObject<List<int>>(responseData);

            }

            for (int i = 0; i < seasonsList.Count(); i++) {
                seasons.Add(new Season() { season = seasonsList[i] }); // from the list of integers, seed them into their own season objects
            }

            return seasons;
        }

    }
}
