using Microsoft.EntityFrameworkCore.Storage;/*
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
        public void Add(User user)
        {
            UserEntity entity = new UserEntity()
            {
                Id = user.Id,
                Name = user.Name,
                Email= user.Email,
                Password= user.Password
            };
            _repository.Add(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public User GetUser(int id)
        {
            UserEntity entity = _repository.GetUser(id);
            User user = new User
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Password = entity.Password
            };
            return user;
        }

        public List<User> GetUsers()
        {
            List<UserEntity> userEntities = _repository.GetUsers();
            List<User> users = userEntities.Select(u => new User()
            {
                Id = u.Id,
                Name = u.Name,
                Email = u.Email,
                Password = u.Password
            }).ToList();
            return users;
        }

        public void Update(User user)
        {
            UserEntity entity = new UserEntity
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };
            _repository.Update(entity);
        }
    }
}
