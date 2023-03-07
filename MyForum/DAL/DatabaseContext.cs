﻿using Microsoft.EntityFrameworkCore;
using MyForum.Models;

namespace MyForum.DAL
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
