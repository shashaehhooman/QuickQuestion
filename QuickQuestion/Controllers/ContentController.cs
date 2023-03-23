using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using QuickQuestion.Domain.Model;
using QuickQuestion.Domain.Services;
using QuickQuestion.Model;

namespace QuickQuestion.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ContentController : Controller
    {
        private readonly IContent _content;

        public ContentController(IContent content)
        {
            _content = content;
        }

        [HttpGet]
        [Route("category/{id:int?}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories(int? id = null)
        {
            var categories = await _content.getCategory(id);
            return Ok(categories);
        }
        
        [HttpGet]
        [Route("blogs/{categoryId:int}")]
        public async Task<ActionResult<IEnumerable<Category>>> GetBlogs(int categoryId)
        {
            var blogs = await _content.getBlogs(categoryId);
            return Ok(blogs);
        }

        [HttpGet]
        [Route("blog/{id:int}")]
        public async Task<ActionResult<Blog>> GetBlog(int id)
        {
            var blog = await _content.getBlog(id);
            return Ok(blog);
        }

        [Authorize]
        [HttpPost("comment")]
        public async Task<ActionResult<User>> AddComment(CommentDto comment)
        {
            if (string.IsNullOrEmpty( comment.description))
            {
                return NotFound("Description is required.");
            }

            var passEncrypt = StringCipher.Encrypt(userDto.Password, passKey);

            if (user.password != passEncrypt)
            {
                return NotFound("Password incorrect.");
            }

            string token = StringCipher.CreateToken(user, tokenKey);

            return Ok(new { user, token });
        }

        [Authorize]
        [HttpPost("answer")]
        public async Task<ActionResult<User>> AddAnswer(AnswerDto answer)
        {
            var user = await _user.getUser(userDto.Username);

            if (user == null)
            {
                return NotFound("Not Found.");
            }

            var passEncrypt = StringCipher.Encrypt(userDto.Password, passKey);

            if (user.password != passEncrypt)
            {
                return NotFound("Password incorrect.");
            }

            string token = StringCipher.CreateToken(user, tokenKey);

            return Ok(new { user, token });
        }
    }
}
