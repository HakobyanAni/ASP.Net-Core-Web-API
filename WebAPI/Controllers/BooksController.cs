using System.Collections.Generic;
using System.Linq;
using Data_Access_Layer;
using Data_Access_Layer.Entities;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        // GET api/Books
        [HttpGet]
        public ActionResult<List<BookModel>> Get()
        {
            using (EFContext MyDBContext = new EFContext())
            {
                List<Book> dbBooks = MyDBContext.Books.ToList();
                return Helper.DBBooksListToBooksModelList(dbBooks);
            }
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public ActionResult<BookModel> Get(int id)
        {
            using (EFContext MyDBContext = new EFContext())
            {
                Book dbBooks = MyDBContext.Books.Find(id);
                if (dbBooks == null)
                {
                    return NotFound();
                }
                return Helper.DBBookToBooksModel(dbBooks);
            }
        }

        [HttpPost] // call by Postman
        public ActionResult<BookModel> PostBook(BookModel book)
        {
            try
            {
                using (EFContext MyDBContext = new EFContext())
                {
                    MyDBContext.Books.Add(Helper.BooksModelToDBBook(book));
                    MyDBContext.SaveChanges();
                }
                return Ok("Ok");
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")] 
        public IActionResult Put(int id, BookModel book)
        {
            using (EFContext MyDBContext = new EFContext())
            {
                Book dbBooks = MyDBContext.Books.Find(id);
                if (dbBooks == null)
                {
                    return NotFound();
                }

                dbBooks.Title = book.Title;
                dbBooks.Genre = book.Genre;
                dbBooks.NumberOfPages = book.NumberOfPages;
                dbBooks.PublicationDate = book.PublicationDate;

                MyDBContext.Entry(dbBooks).State = EntityState.Modified;
                MyDBContext.SaveChanges();
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Book> Delete(int id)
        {
            using (EFContext MyDBContext = new EFContext())
            {
                var book = MyDBContext.Books.Find(id);
                if (book == null)
                {
                    return NotFound();
                }

                MyDBContext.Books.Remove(book);
                MyDBContext.SaveChanges();
                return book;
            }
        }
    }
}