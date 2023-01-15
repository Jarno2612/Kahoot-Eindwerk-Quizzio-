using Domain.Models;
using HostApp.Services.Contracts;

namespace HostApp.Services
{
    public class GameService : IGameService
    {
        private readonly HttpClient _httpClient;

        public GameService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Game>> GetGames()
        {
            var games = await _httpClient.GetFromJsonAsync<List<Game>>("/games");
            return games;
        }
    }
}
