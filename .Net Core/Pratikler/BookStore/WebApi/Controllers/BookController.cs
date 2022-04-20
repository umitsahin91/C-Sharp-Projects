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
        new Book(){Id=1,Title="LeanStartup",GenreId=1,/*Personel Growth*/PageCount=200,PublishDate=new DateTime(2010,12,21)},
        new Book(){Id=2,Title="Herland",GenreId=2,/*Science Fiction*/PageCount=250,PublishDate=new DateTime(2010,12,21)},
        new Book(){Id=3,Title="Dune",GenreId=2,/*Science Fiction*/PageCount=540,PublishDate=new DateTime(2010,12,21)}
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
    }
}
