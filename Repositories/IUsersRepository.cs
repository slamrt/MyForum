using MyForum.Models;

namespace MyForum.Repositories
{
    public interface IUsersRepository
    {
        List<UserEntity> GetUsers();
        UserEntity GetUser(int id);
        void Update(UserEntity user);
        void Add(UserEntity user);
        void Delete(int id);
    }
}
