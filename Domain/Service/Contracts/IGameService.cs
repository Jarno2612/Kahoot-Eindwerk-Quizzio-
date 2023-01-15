using Domain.Models;

namespace Domain.Service.Contracts
{
    public interface IGameService
    {
        Task<List<Game>> GetGames();
        Game GetGameById(Guid id);
        void CreateGame(Game game);

    }
}