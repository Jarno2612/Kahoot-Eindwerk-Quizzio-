using Domain.Models;

namespace Domain.Service.Contracts
{
    public interface IQuestionService
    {
        Task<List<Question>> GetQuestions();
        Question GetQuestionById(Guid id);
        void CreateQuestion(Question question);

    }
}