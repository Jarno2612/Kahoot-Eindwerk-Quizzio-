using Domain.Models;
using Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("UserGames")]
    [ApiController]

    public class UserGameController
    {
        private readonly IUserGameService _userGameService;

        public UserGameController(IUserGameService userGameService)
        {
            _userGameService = userGameService;
        }


        #region GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<List<UserGame>> GetUserGamesAsync()
        {
            return await _userGameService.GetUserGames();
        }

        [HttpGet("id/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public UserGame GetUserGameById([FromRoute] Guid id)
        {
            return _userGameService.GetUserGameById(id);
        }



        #endregion

        #region CREATE  
        [HttpPut]

        public void CreateUserGame(UserGame userGame)
        {
            _userGameService.CreateUserGame(userGame);
        }
        #endregion


    }
}
