/*using Microsoft.EntityFrameworkCore.Storage;
using MyForum.DAL;*/
using MyForum.Models;
using MyForum.Repositories;

namespace MyForum.Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repository;
        public UsersService(IUsersRepository repository)
        {
            _repository = repository;
        }
        public void Add(UserEntity user)
        {
            _repository.Add(user);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public UserEntity GetUser(int id)
        {
            return _repository.GetUser(id);
        }

        public List<UserEntity> GetUsers()
        {
            return _repository.GetUsers();
        }

        public void Update(UserEntity user)
        {
            _repository.Update(user);
        }
    }
}
