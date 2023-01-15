

using HostApp.Data;

namespace HostApp.Services.Contracts
{
    public interface IUserService
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(Guid id);
        
        void CreateUser(User user);


    }
}
