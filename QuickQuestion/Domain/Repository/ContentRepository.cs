using Microsoft.EntityFrameworkCore;
using QuickQuestion.Domain.Model;
using QuickQuestion.Domain.Services;

namespace QuickQuestion.Domain.Repository
{
    public class ContentRepository : IContent
    {
        private readonly QuickQuestionContext _context;
        public ContentRepository(QuickQuestionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> getCategory(int? id = null)
        {
            return await _context.Category
                .Where(x => x.superId == id)
                .ToListAsync();
        }

        public async Task<IEnumerable<Blog>> getBlogs(int categoryId)
        {
            return await _context.Blog
                 .Where(x => x.categoryId == categoryId)
                 .ToListAsync();
        }

        public async Task<Blog> getBlog(int id)
        {
            var product = await _context.Blog
                .Include(x=>x.assets)
                .Include(x=>x.blogTags)
                .Include(x=>x.comments.Take(10)).ThenInclude(emp => emp.answers.Take(5))
                .Include(x => x.user)
                .Where(x => x.id == id)
                .SingleOrDefaultAsync();

            return product == null ? new Blog() : product;
        }

    }
}
