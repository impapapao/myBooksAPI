using Microsoft.EntityFrameworkCore;
using myBooksAPI.Models;

namespace myBooksAPI.Db_Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
