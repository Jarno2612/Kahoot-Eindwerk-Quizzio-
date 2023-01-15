using Domain.Models;

namespace Persistance.Repositories
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        User GetUserById(Guid id);
        void CreateUser(User user);
    }
}