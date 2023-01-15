using Domain.Models;

namespace Persistance.Repositories
{
    public interface IGameRepository
    {
        Task<List<Game>> GetGames();
        Game GetGameById(Guid id);
        void CreateGame(Game game);


    }
}