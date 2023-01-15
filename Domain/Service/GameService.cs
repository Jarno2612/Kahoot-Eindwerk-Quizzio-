using Domain.Models;
using Domain.Service.Contracts;
using Persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Service
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _gameRepository;


        public GameService(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public Task<List<Game>> GetGames()
        {
            return _gameRepository.GetGames();
        }
        public Game GetGameById(Guid id)
        {
            return _gameRepository.GetGameById(id);
        }
        public void CreateGame(Game game)
        {
            if (GetGameById(game.Id) == null)
            {
                _gameRepository.CreateGame(game);
            }
            else
            {
                throw new Exception("Game already exists");
            }
        }

    }
}
