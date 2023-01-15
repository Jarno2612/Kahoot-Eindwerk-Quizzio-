using Domain.Models;

namespace Persistance.Repositories
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetQuestions();
        Question GetQuestionById(Guid id);
        void CreateQuestion(Question question);

    }
}