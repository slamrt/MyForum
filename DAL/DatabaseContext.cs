using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        public DbSet<UserEntity> Users { get; set; }
    }
}
