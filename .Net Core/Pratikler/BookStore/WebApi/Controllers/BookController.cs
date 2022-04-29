using AutoMapper;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.DeleteBook;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.GetBooks;
using WebApi.BookOperations.UpdateBook;
using WebApi.DBOperations;

namespace WebApi.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public BookController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetBooks()
        {
            GetBooksQuery query = new GetBooksQuery(_context,_mapper);
            var result = query.Handler();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
           
            BookDetailViewModel result;
            GetBookDetailQuery query = new GetBookDetailQuery(_context,_mapper);
            try
            {
                query.BookId = id;
                GetBookDetailQueryValidator validations = new GetBookDetailQueryValidator();
                validations.ValidateAndThrow(query);
                result = query.Handler();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
            return Ok(result);
        }
        //[HttpGet]
        //public Book Get([FromQuery]string id)
        //{
        //    var book = books.Where(x => x.Id == Convert.ToInt32(id)).SingleOrDefault();

        //    return book;
        //}

        [HttpPost]
        public IActionResult AddBook([FromBody] CreateBookModel newBook)
        {
            CreateBookCommand command = new CreateBookCommand(_context,_mapper);
            try
            {           
                command.Model = newBook;
                CreateBookCommandValidator validator = new CreateBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handler();
                //if (!result.IsValid)
                //    result.Errors.ForEach(message => Console.WriteLine($"Property : {message.PropertyName} Eror Message : {message.ErrorMessage}"));
                //else
                //command.Handler();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return Ok();
                        
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id,[FromBody] UpdateBookModel updatedBook)
        {
            UpdateBookCommand command = new UpdateBookCommand(_context);
            try
            {
                command.Model = updatedBook;
                command.BookId = id;
                UpdateBookCommandValidator validations = new UpdateBookCommandValidator();
                validations.ValidateAndThrow(command);
                command.Handler();
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            DeleteBookCommand command = new DeleteBookCommand(_context);
            try
            {
                command.BookId = id;
                DeleteBookCommandValidator validator = new DeleteBookCommandValidator();
                validator.ValidateAndThrow(command);
                command.Handler();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
        
    }
}
