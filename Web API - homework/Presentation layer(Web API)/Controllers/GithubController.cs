using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Presentation_layer_Web_API_.Models;

namespace Presentation_layer_Web_API_.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class GithubController : ControllerBase
    {
        // GET: api/Github
        /// <summary>
        /// Get all Github profiles
        /// </summary>
        [HttpGet]
        public IEnumerable<GithubProfileModel> GetGithubProfile()
        {
            using (DbManager manager = new DbManager())
            {
                return manager.GetAllGitHubProfiles();
            }
        }

        // GET: api/Github/5
        /// <summary>
        /// Get a Github profile by Id
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<GithubProfileModel> GetGithubProfile(int id)
        {
            using (DbManager manager = new DbManager())
            {
                if (manager.GetAGithubProfile(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    return manager.GetAGithubProfile(id);
                }
            }
        }
    }
}
