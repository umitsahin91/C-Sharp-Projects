﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                context.Books.AddRange(
                    new Book() { Id = 1, Title = "LeanStartup", GenreId = 1,/*Personel Growth*/PageCount = 200, PublishDate = new DateTime(2010, 12, 21) },
                    new Book() { Id = 2, Title = "Herland", GenreId = 2,/*Science Fiction*/PageCount = 250, PublishDate = new DateTime(2010, 12, 21) },
                    new Book() { Id = 3, Title = "Dune", GenreId = 2,/*Science Fiction*/PageCount = 540, PublishDate = new DateTime(2010, 12, 21) }
                    );
                context.SaveChanges();
            }
        }
    }
}
