using QuickQuestion.Domain.Model;

namespace QuickQuestion.Domain.Services
{
    public interface IQuestions
    {
        Task<IEnumerable<Comment>> getComments(int blogId);

        Task<IEnumerable<Answer>> getAnswers(int commentId);

        Task<bool> insetComment(Comment comment);
        
        Task<bool> insetAnswer(Answer answer);
    }
}
