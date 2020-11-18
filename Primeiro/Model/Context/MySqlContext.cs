using Microsoft.EntityFrameworkCore;
using System;

namespace Primeiro.Model.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext()
        {

        }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<User> Users { get; set; }

        internal bool Any(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        internal object SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
