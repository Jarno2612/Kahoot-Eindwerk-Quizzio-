using Domain.Models;

namespace Domain.Service.Contracts
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        User GetUserById(Guid id);
        void CreateUser(User user);

    }
}