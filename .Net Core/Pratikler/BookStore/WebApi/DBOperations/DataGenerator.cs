using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }

                context.Genres.AddRange(
                     new Genre() { Name = "Personal Growth" },
                     new Genre() { Name = "Science Fiction" },
                     new Genre() { Name = "Romance" }
                    );

                context.Books.AddRange(
                    new Book() { Title = "LeanStartup", GenreId = 1,PageCount = 200, PublishDate = new DateTime(2010, 12, 21) },
                    new Book() { Title = "Herland", GenreId = 2,PageCount = 250, PublishDate = new DateTime(2010, 12, 21) },
                    new Book() { Title = "Dune", GenreId = 3,PageCount = 540, PublishDate = new DateTime(2010, 12, 21) }
                    );
                context.SaveChanges();
            }
        }
    }
}
