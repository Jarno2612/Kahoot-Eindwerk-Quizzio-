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
    public class QuestionRepository : IQuestionRepository
    {
        private readonly KahootContext _kahootContext;
        public QuestionRepository(KahootContext kahootContext)
        {
            _kahootContext = kahootContext;
        }

        #region GET
        public async Task<List<Question>> GetQuestions()
        {
            List<Question> questions = await _kahootContext.Question.Include(q => q.Answers).ToListAsync();
            return questions;
        }

        public Question GetQuestionById(Guid id)
        {
            Question question = _kahootContext.Question.FirstOrDefault(q => q.Id == id);
            return question;
        }

        #endregion


        #region CREATE
        public void CreateQuestion(Question question)
        {
            _kahootContext.Question.Add(question);
            _kahootContext.SaveChanges();

        }
        #endregion  

    }
}
