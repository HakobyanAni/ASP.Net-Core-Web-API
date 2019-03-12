using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer;
using WebAPI.Models;
using Data_Access_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        // GET api/Authors
        [HttpGet]
        public ActionResult<List<AuthorModel>> Get()
        {
            using (DbAuthorManager myDbManager = new DbAuthorManager())
            {
                return myDbManager.GetAllAuthors();
            }
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public ActionResult<AuthorModel> Get(int id)
        {
            using (DbAuthorManager myDbManager = new DbAuthorManager())
            {
                if (myDbManager.GetAnAuthor(id) == null)
                {
                    return NotFound();
                }
                return myDbManager.GetAnAuthor(id);
            }
        }

        [HttpPost]  // call by Postman
        public ActionResult<string> Post(AuthorModel author)
        {
            using (DbAuthorManager myDbManager = new DbAuthorManager())
            {
                bool isAdded = myDbManager.AddAuthor(author);
                if(isAdded)
                {
                    return Ok("Ok");
                }
                else
                {
                    return BadRequest();
                }
            }
        }

        [HttpPut("{id}")]  // call by Postman
        public IActionResult Put(int id, AuthorModel author)
        {
            using (DbAuthorManager myDbManager = new DbAuthorManager())
            {
                bool isEdited = myDbManager.EditAuthotr(id, author);
                if (isEdited)
                {
                    return NoContent();
                }
                else
                { 
                    return NotFound();
                }
            }
        }

        [HttpDelete("{id}")]  // call by Postman
        public ActionResult<Author> Delete(int id)
        {
            using (DbAuthorManager myDbManager = new DbAuthorManager())
            {
                bool isDeleted = myDbManager.DeleteAuthor(id);
                if (isDeleted)
                {
                    return Ok("Author is deleted.");
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
