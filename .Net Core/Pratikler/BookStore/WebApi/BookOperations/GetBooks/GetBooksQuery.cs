using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DBOperations;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        public GetBooksQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<BooksViewsModel> Handler()
        {
            var bookList = _dbContext.Books.OrderBy(x => x.Id).ToList<Book>();
            List<BooksViewsModel> vm = new List<BooksViewsModel>();
            foreach (var book in bookList)
            {
                vm.Add(new BooksViewsModel()
                    {
                        Title = book.Title,
                        Genre = ((GenreEnum)book.GenreId).ToString(),
                        PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
                        PageCount = book.PageCount
                    });
            }
            return vm;
        }
    }

    public class BooksViewsModel
    {
        public string Title { get; set; }
        public int PageCount { get; set; }
        public String PublishDate { get; set; }
        public string Genre { get; set; }
    }
}
