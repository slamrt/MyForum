using Microsoft.EntityFrameworkCore.Storage;
using MyForum.DAL;
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
        public void Add(User user)
        {
            _repository.Add(user);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public User GetUser(int id)
        {
            return _repository.GetUser(id);
        }

        public List<User> GetUsers()
        {
            return _repository.GetUsers();
        }

        public void Update(User user)
        {
            _repository.Update(user);
        }
    }
}
