using Domain.Models;

namespace Domain.Service.Contracts
{
    public interface IUserGameService
    {
        Task<List<UserGame>> GetUserGames();
        UserGame GetUserGameById(Guid id);
        void CreateUserGame(UserGame userGame);
    }
}