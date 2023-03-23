using QuickQuestion.Domain.Model;

namespace QuickQuestion.Domain.Services
{
    public interface IContent
    {

        Task<IEnumerable<Category>> getCategory(int? id = null);

        Task<IEnumerable<Blog>> getBlogs(int categoryId);

        Task<Blog> getBlog(int id);
    }
}
