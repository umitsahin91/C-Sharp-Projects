using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class BookController : ControllerBase
    {
        
        private static List<Book> books = new List<Book> ()
        {
       
        };

        [HttpGet]
        public List<Book> GetBooks()
        {
            var bookList = books.OrderBy(x => x.Id).ToList<Book>();
            return bookList;
        }

        [HttpGet("{id}")]
        public Book GetById(int id)
        {
            var book = books.Where(x => x.Id == id).SingleOrDefault();

            return book;
        }
        //[HttpGet]
        //public Book Get([FromQuery]string id)
        //{
        //    var book = books.Where(x => x.Id == Convert.ToInt32(id)).SingleOrDefault();

        //    return book;
        //}

        [HttpPost]
        public IActionResult AddBook([FromBody] Book newBook)
        {
            var book = books.SingleOrDefault(x => x.Title == newBook.Title);
            if (book is not null)
                return BadRequest();
            books.Add(newBook);
            return Ok();
            
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id,[FromBody] Book updatedBook)
        {
            var book = books.SingleOrDefault(x => x.Id == id);
            if (book is null)
                return BadRequest();

            book.Title = updatedBook.Title != default ? updatedBook.Title : book.Title;
            book.PageCount = updatedBook.PageCount != default ? updatedBook.PageCount : book.PageCount;
            book.PublishDate = updatedBook.PublishDate != default ? updatedBook.PublishDate : book.PublishDate;
            book.GenreId = updatedBook.GenreId != default ? updatedBook.GenreId : book.GenreId;

            return Ok();

            
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book = books.SingleOrDefault(x => x.Id == id);
            if (book is null)
                return BadRequest();
            
            books.Remove(book);
            return Ok();
        }
        
    }
}
