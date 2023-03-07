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

        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var UserToDelete = _context.Users.FirstOrDefault(u => u.Id == id);
            _context.Remove(UserToDelete);
            _context.SaveChanges();
        }

        public User GetUser(int id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
