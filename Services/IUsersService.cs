using MyForum.Models;

namespace MyForum.Services
{
    public interface IUsersService
    {
        List<UserEntity> GetUsers();
        UserEntity GetUser(int id);
        void Add(UserEntity user);
        void Delete(int id);
        void Update(UserEntity user);
    }
}
