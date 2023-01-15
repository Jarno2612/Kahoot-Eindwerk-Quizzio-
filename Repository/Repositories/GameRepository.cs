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
    public class GameRepository : IGameRepository
    {
        private readonly KahootContext _kahootContext;
        public GameRepository(KahootContext kahootContext)
        {
            _kahootContext = kahootContext;
        }

        #region GET
        public async Task<List<Game>> GetGames()
        {
            List<Game> games = await _kahootContext.Game.Include(g => g.Questions).Include(a => a.Admin).ToListAsync();
            return games;
        }

        public Game GetGameById(Guid id)
        {
            Game game = _kahootContext.Game.FirstOrDefault(g => g.Id == id);
            return game;
        }

        #endregion


        #region CREATE
        public void CreateGame(Game game)
        {
            _kahootContext.Game.Add(game);
            _kahootContext.SaveChanges();

        }
        #endregion  
    }
}
