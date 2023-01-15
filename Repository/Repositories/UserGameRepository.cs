using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class UserGameRepository : IUserGameRepository
    {

        private readonly KahootContext _kahootContext;

        public UserGameRepository(KahootContext kahootContext)
        {
            _kahootContext = kahootContext;
        }

        #region GET
        public async Task<List<UserGame>> GetUserGames()
        {
            List<UserGame> usergames = await _kahootContext.UserGame.ToListAsync();
            return usergames;
        }

        public UserGame GetUserGameById(Guid id)
        {
            UserGame userGame = _kahootContext.UserGame.FirstOrDefault(u => u.Id == id);
            return userGame;
        }
        #endregion

        #region CREATE
        public void CreateUserGame(UserGame userGame)
        {
            _kahootContext.UserGame.Add(userGame);
            _kahootContext.SaveChanges();
        }
#endregion
    }
}