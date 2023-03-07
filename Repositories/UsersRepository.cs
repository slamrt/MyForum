using MyForum.DAL;
using MyForum.Models;

namespace MyForum.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DatabaseContext _context;
        public UsersRepository(DatabaseContext context)
        {
            _context = context;
        }

        public void Add(UserEntity user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var userToDelete = _context.Users.FirstOrDefault(u => u.Id == id);
            _context.Remove(userToDelete);
            _context.SaveChanges();
        }

        public UserEntity GetUser(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public List<UserEntity> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void Update(UserEntity user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
