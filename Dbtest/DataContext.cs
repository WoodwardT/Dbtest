using Microsoft.EntityFrameworkCore;

namespace Dbtest
{
    public class DataContext : DbContext
    {


        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=database.db");
        }


    }
}
