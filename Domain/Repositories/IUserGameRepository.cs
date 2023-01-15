using Domain.Models;

namespace Persistance.Repositories
{
    public interface IUserGameRepository
    {
        Task<List<UserGame>> GetUserGames();
        UserGame GetUserGameById(Guid id);
        void CreateUserGame(UserGame userGame);
    }
}