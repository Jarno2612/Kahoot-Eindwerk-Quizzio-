using Domain.Models;
using Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("Answers")]
    [ApiController]
    public class AnswerController 
    {
        private readonly IAnswerService _answerService;

        public AnswerController(IAnswerService answerService)
        {
            _answerService = answerService;
        }

        #region GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<List<Answer>> GetAnswersAsync()
        {
            return await _answerService.GetAnswers();
        }
        [HttpGet("id/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public Answer GetAnswerById([FromRoute] Guid id)
        {
            return _answerService.GetAnswerById(id);
        }



        #endregion

        #region CREATE  
        [HttpPut]

        public void CreateAnswer(Answer answer)
        {
            _answerService.CreateAnswer(answer);
        }
        #endregion
    }
}
