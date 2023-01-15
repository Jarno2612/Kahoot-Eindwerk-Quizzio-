using Domain.Models;
using Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("Users")]
    [ApiController]

    public class UserController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        #region GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userService.GetUsers();
        }
        [HttpGet("id/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public User GetUserById([FromRoute] Guid id)
        {
            return _userService.GetUserById(id);
        }



        #endregion

        #region CREATE  
        [HttpPut]

        public void CreateUser(User user)
        {
            _userService.CreateUser(user);
        }
        #endregion

    }
}
