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
            using (DbBookManager myDbManager = new DbBookManager())
            {
                return myDbManager.GetAllBooks();
            }
        }

        // GET: api/Books/5
        [HttpGet("{id}")]
        public ActionResult<BookModel> Get(int id)
        {
            using (DbBookManager myDbManager = new DbBookManager())
            {
                if(myDbManager.GetABook(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    return myDbManager.GetABook(id);
                }
            }
        }

        [HttpPost] // call by Postman
        public IActionResult PostBook(BookModel book)
        {
            using (DbBookManager myDbManager = new DbBookManager())
            {
                bool isadded = myDbManager.AddBook(book);
                if (isadded)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpPut("{id}")] // call by Postman
        public IActionResult Put(int id, BookModel book)
        {
            using (DbBookManager myDbManager = new DbBookManager())
            {
                bool isput = myDbManager.EditBook(id, book);
                if(isput)
                {
                    return NoContent();
                }
                else
                {
                    return NotFound();
                }
            }
        }

        [HttpDelete("{id}")] // call by Postman
        public IActionResult Delete(int id)
        {
            using (DbBookManager myDbManager = new DbBookManager())
            {
                bool isDeleted = myDbManager.DeleteBook(id);
                if(isDeleted)
                {
                    return Ok("Book is deleted");
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}