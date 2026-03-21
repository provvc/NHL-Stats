using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NHLStatsAPI.Models;
using System.Text.Json;

namespace NHLStatsAPI.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller {

        private readonly HttpClient _httpClient;

        public TeamController(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        [HttpGet(Name = "GetTeams")]
        public async Task<List<Team>> GetTeams() {
            var teams = new List<Team>();

            _httpClient.DefaultRequestHeaders.Clear();
            _httpClient.DefaultRequestHeaders.Add("Accept", "application/json");

            string endpoint = $"https://api.nhle.com/stats/rest/en/team";

            var response = await _httpClient.GetStringAsync(endpoint);

            var jObject = JObject.Parse(response);

            teams = jObject["data"].ToObject<List<Team>>();

            //if (response.IsSuccessStatusCode) {
            //    var doc = JsonDocument.Parse(response);
            //    string responseData = await response.Content.ReadAsStringAsync();
                
            //}

            return teams;

        }
    }
}
