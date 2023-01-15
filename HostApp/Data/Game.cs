
namespace HostApp.Data
{
   
        public class Game
        {
            public List<Question> Questions { get; set; }
            public User Admin { get; set; }
            public Guid Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            private List<UserGame> _userGames = new();
            public List<UserGame> UserGames => _userGames;

        }

    
}
