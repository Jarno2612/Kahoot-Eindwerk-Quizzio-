

namespace HostApp.Data
{
    public class Question
    {
        public List<Answer> Answers { get; set; }
        public Guid Id { get; set; }
        public string Description { get; set; }

    }
}
