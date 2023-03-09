using Models;

namespace Repositories
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
