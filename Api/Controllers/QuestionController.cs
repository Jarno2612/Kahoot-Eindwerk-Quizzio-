using Domain.Models;
using Domain.Service.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("Questions")]
    [ApiController]

    public class QuestionController 
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        #region GET
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<List<Question>> GetQuestionsAsync()
        {
            return await _questionService.GetQuestions();
        }
        [HttpGet("id/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public Question GetQuestionById([FromRoute] Guid id)
        {
            return _questionService.GetQuestionById(id);
        }



        #endregion

        #region CREATE  
        [HttpPut]

        public void CreateQuestion(Question question)
        {
            _questionService.CreateQuestion(question);
        }
        #endregion

    }
}
