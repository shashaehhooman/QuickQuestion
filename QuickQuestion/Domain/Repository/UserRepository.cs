using Microsoft.EntityFrameworkCore;
using QuickQuestion.Domain.Model;
using QuickQuestion.Domain.Services;

namespace QuickQuestion.Domain.Repository
{
    public class UserRepository : IUser
    {

        private readonly QuickQuestionContext _context;
        public UserRepository(QuickQuestionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Role>> getRoles()
        {
            return await _context.Role
                 .ToListAsync();
        }

        public async Task<User?> getUser(string email)
        {
            var user = await _context.User
                 .Where(x => x.email == email)
                 .FirstOrDefaultAsync();

            return user;
        }

        public async Task<IEnumerable<User>> getUsers(int roleId)
        {
            return await _context.User
                .Where(x => x.userRoles.Any(u => u.roleId == roleId))
                .ToListAsync();
        }

        public async Task<bool> insetUser(User user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return true;
        }

    }
}
