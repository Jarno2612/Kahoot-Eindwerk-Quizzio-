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
    public class AnswerRepository : IAnswerRepository
    {
        private readonly KahootContext _kahootContext;
        public AnswerRepository(KahootContext kahootContext)
        {
            _kahootContext= kahootContext;
        }

        #region GET

        public async Task<List<Answer>> GetAnswers()
        {
            List<Answer> answers = await _kahootContext.Answer.ToListAsync();
            return answers;
        }

        public Answer GetAnswerById(Guid id)
        {
            Answer answer = _kahootContext.Answer.FirstOrDefault(a => a.Id == id);
            return answer;
        }

        #endregion

        #region CREATE
        public void CreateAnswer(Answer answer)
        {
            _kahootContext.Answer.Add(answer);
            _kahootContext.SaveChanges();
            
        }
        #endregion  



    }
}
