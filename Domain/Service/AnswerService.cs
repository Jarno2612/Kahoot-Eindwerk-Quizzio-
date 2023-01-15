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
    public class AnswerService : IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;


        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        public Task<List<Answer>> GetAnswers()
        {
            return _answerRepository.GetAnswers();
        }
        public Answer GetAnswerById(Guid id)
        {
            return _answerRepository.GetAnswerById(id);
        }
        public void CreateAnswer(Answer answer)
        {
            if (GetAnswerById(answer.Id) == null)
            {
                _answerRepository.CreateAnswer(answer);
            }
            else
            {
                throw new Exception("Answer already exists");
            }
        }
    }
}
