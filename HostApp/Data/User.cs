using System.ComponentModel.DataAnnotations;

namespace HostApp.Data
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a email")]

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        private List<UserGame> _userGames = new();

        public List<UserGame> UserGames => _userGames;

    }
}
