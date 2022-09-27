using System;
using Duitkuh.Model;
using Microsoft.EntityFrameworkCore;

namespace Duitkuh.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRole { get; set; }
    }
}

