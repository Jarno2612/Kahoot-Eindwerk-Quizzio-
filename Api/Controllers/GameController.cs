using Domain.Models;
using Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("Games")]
    [ApiController]

    public class GameController
    {

        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        #region GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<List<Game>> GetGamesAsync()
        {
            return await _gameService.GetGames();
        }
        [HttpGet("id/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public Game GetGameById([FromRoute] Guid id)
        {
            return _gameService.GetGameById(id);
        }



        #endregion

        #region CREATE  
        [HttpPut]

        public void CreateGame(Game game)
        {
            _gameService.CreateGame(game);
        }
        #endregion
    }
}
