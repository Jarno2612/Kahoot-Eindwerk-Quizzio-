using Domain.Models;

namespace HostApp.Services.Contracts
{
    public interface IGameService
    {
        Task<List<Game>> GetGames();
    }
}
