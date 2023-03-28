using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using myBooksAPI.Db_Context;
using myBooksAPI.Models;
using System.Linq;

namespace myBooksAPI.Data
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        title = "1st Book Title",
                        Description = "1st Book Description",
                        Author = "1st Author",
                        Genre = "Biography",
                        IsRead = true,
                        DateRead = System.DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverUrl = "https . . . . . .",
                        DateAdded = System.DateTime.Now
                    },
                    new Book()
                    {
                        title = "2nd Book Title",
                        Description = "2st Book Description",
                        Author = "2st Author",
                        Genre = "Biography",
                        IsRead = false,
                        DateRead = System.DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverUrl = "https . . . . . .",
                        DateAdded = System.DateTime.Now
                    },
                    new Book()
                    {
                        title = "3rd Book Title",
                        Description = "3rd Book Description",
                        Author = "3rd Author",
                        Genre = "Fantasy",
                        IsRead = false,
                        DateRead = System.DateTime.Now.AddDays(-10),
                        Rate = 4,
                        CoverUrl = "https . . . . . .",
                        DateAdded = System.DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
