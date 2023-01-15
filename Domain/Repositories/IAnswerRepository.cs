using Domain.Models;

namespace Persistance.Repositories
{
    public interface IAnswerRepository
    {
        #region GET

        Task<List<Answer>> GetAnswers();

        Answer GetAnswerById(Guid id);
        #endregion

        #region CREATE
        void CreateAnswer(Answer answer);
        #endregion  

    }
}