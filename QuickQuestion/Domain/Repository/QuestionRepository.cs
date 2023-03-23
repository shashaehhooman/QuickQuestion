using Microsoft.EntityFrameworkCore;
using QuickQuestion.Domain.Model;
using QuickQuestion.Domain.Services;

namespace QuickQuestion.Domain.Repository
{
    public class QuestionRepository: IQuestions
    {
        private readonly QuickQuestionContext _context;
        public QuestionRepository(QuickQuestionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Comment>> getComments(int blogId)
        {
            return await _context.Comment
                .Include(x=> x.answers.Take(5))
             .Where(x => x.blogId == blogId)
             .ToListAsync();
        }

        public async Task<IEnumerable<Answer>> getAnswers(int commentId)
        {
            return await _context.Answer
                .Where(x => x.commetnId == commentId)
                .ToListAsync();
        }

        public async Task<bool> insetComment(Comment comment)
        {
            await _context.Comment.AddAsync(comment);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> insetAnswer(Answer answer)
        {
            await _context.Answer.AddAsync(answer);
            await _context.SaveChangesAsync();

            return true;
        }


    }
}
