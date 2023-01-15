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
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository _questionRepository;


        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public Task<List<Question>> GetQuestions()
        {
            return _questionRepository.GetQuestions();
        }
        public Question GetQuestionById(Guid id)
        {
            return _questionRepository.GetQuestionById(id);
        }
        public void CreateQuestion(Question question)
        {
            if (GetQuestionById(question.Id) == null)
            {
                _questionRepository.CreateQuestion(question);
            }
            else
            {
                throw new Exception("Answer already exists");
            }
        }

    }
}
