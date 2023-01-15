using Domain.Models;

namespace Domain.Service.Contracts
{
    public interface IAnswerService
    {
        Task<List<Answer>> GetAnswers();
        Answer GetAnswerById(Guid id);
        void CreateAnswer(Answer answer);

    }
}