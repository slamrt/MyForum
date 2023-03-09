using Models;

namespace Services
{
    public interface IUsersService
    {
        List<User> GetUsers();
        User GetUser(int id);
        void Add(User userDTO);
        void Delete(int id);
        void Update(User user);
    }
}
