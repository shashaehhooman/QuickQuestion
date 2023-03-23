using QuickQuestion.Domain.Model;

namespace QuickQuestion.Domain.Services
{
    public interface IUser
    {
        Task<IEnumerable<User>> getUsers(int roleId);

        Task<IEnumerable<Role>> getRoles();

        Task<User?> getUser(string userName);

        Task<bool> insetUser(User user);

    }
}
