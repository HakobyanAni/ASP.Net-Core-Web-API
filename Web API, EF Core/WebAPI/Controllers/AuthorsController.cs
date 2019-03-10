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
            using (EFContext MyDBContext = new EFContext())
            {
                List<Author> dbAuthors = MyDBContext.Authors.ToList();
                return Helper.DBAuthorsListToAuthorsModelList(dbAuthors);
            }
        }

        // GET: api/Authors/5
        [HttpGet("{id}")]
        public ActionResult<AuthorModel> Get(int id)
        {
            using (EFContext MyDBContext = new EFContext())
            {
                Author dbAuthors = MyDBContext.Authors.Find(id);
                if (dbAuthors == null)
                {
                    return NotFound();
                }
                return Helper.DBAuthorsToAuthorsModel(dbAuthors);
            }
        }

        [HttpPost]
        public ActionResult<string> Post(AuthorModel author)
        {
            try
            {
                using (EFContext MyDBContext = new EFContext())
                {
                    MyDBContext.Authors.Add(Helper.AuthorsModelToDBAuthors(author));
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
        public IActionResult Put(int id, Author author)
        {
            using (EFContext MyDBContext = new EFContext())
            {
                if (id != author.Id)
                {
                    return BadRequest();
                }

                MyDBContext.Entry(author).State = EntityState.Modified;
                MyDBContext.SaveChanges();
                return NoContent();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Author> Delete(int id)
        {
            using (EFContext MyDBContext = new EFContext())
            {
                var author = MyDBContext.Authors.Find(id);
                if (author == null)
                {
                    return NotFound();
                }

                MyDBContext.Authors.Remove(author);
                MyDBContext.SaveChanges();
                return author;
            }
        }
    }
}
