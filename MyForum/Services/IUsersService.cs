using MyForum.Models;

namespace MyForum.Services
{
    public interface IUsersService
    {
        List<User> GetUsers();
        User GetUser(int id);
        void Add(User user);
        void Delete(int id);
        void Update(User user);
    }
}
