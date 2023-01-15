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
    public class UserGameService : IUserGameService
    {
        private readonly IUserGameRepository _userGameRepository;


        public UserGameService(IUserGameRepository userGameRepository)
        {
            _userGameRepository = userGameRepository;
        }

        public Task<List<UserGame>> GetUserGames()
        {
            return _userGameRepository.GetUserGames();
        }
        public UserGame GetUserGameById(Guid id)
        {
            return _userGameRepository.GetUserGameById(id);
        }
        public void CreateUserGame(UserGame userGame)
        {
            if (GetUserGameById(userGame.Id) == null)
            {
                _userGameRepository.CreateUserGame(userGame);
            }
            else
            {
                throw new Exception("Answer already exists");
            }

        }

    }
}

