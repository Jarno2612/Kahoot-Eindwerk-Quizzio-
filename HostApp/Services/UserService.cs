using HostApp.Data;
using HostApp.Services.Contracts;


namespace HostApp.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<User>> GetUsers()
        {
            var users = await _httpClient.GetFromJsonAsync<List<User>>("/users");
            return users;
        }
        public async Task<User> GetUserById(Guid id)
        {
            var user = await _httpClient.GetFromJsonAsync<User>("/user/{id}");
            return user;
        }



        public void CreateUser(User user)
        {
            throw new NotImplementedException();
        }


    }
}
