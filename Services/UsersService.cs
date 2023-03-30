using AutoMapper;
using Microsoft.EntityFrameworkCore.Storage;
using Models;
using Repositories;

namespace Services
{
    public class UsersService : IUsersService
    {
        private readonly IUsersRepository _repository;
        private readonly IMapper _mapper;
        public UsersService(IUsersRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void Add(User user)
        {
            /*UserEntity entity = new UserEntity()
            {
                Id = user.Id,
                Name = user.Name,
                Email= user.Email,
                Password= user.Password
            };
            _repository.Add(entity);*/
            _repository.Add(_mapper.Map<UserEntity>(user));
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public User GetUser(int id)
        {
            /*UserEntity entity = _repository.GetUser(id);
            User user = new User
            {
                Id = entity.Id,
                Name = entity.Name,
                Email = entity.Email,
                Password = entity.Password
            };
            return user;*/
            var entity = _repository.GetUser(id);
            return _mapper.Map<User>(entity);
        }

        public List<User> GetUsers()
        {
            List<UserEntity> userEntities = _repository.GetUsers();
            return _mapper.Map<List<User>>(userEntities);
        }

        public void Update(User user)
        {
            /*UserEntity entity = new UserEntity
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Password = user.Password
            };*/
            _repository.Update(_mapper.Map<UserEntity>(user));
        }
    }
}
