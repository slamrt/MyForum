using MyForum.Models;

namespace MyForum.Repositories
{
    public interface IUsersRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
        void Update(User user);
        void Add(User user);
        void Delete(int id);
    }
}
