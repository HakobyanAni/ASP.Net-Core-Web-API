using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Presentation_layer_Web_API_.Models;

namespace Presentation_layer_Web_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        // GET: api/Job
        [HttpGet]
        public IEnumerable<JobModel> GetJob()
        {
            using (DbManager dbManager = new DbManager())
            {
                return dbManager.GetAllJobs();
            }
        }

        // GET: api/Job/5
        [HttpGet("{id}")]
        public ActionResult<JobModel> GetJob(int id)
        {
            using (DbManager manager = new DbManager())
            {
                if (manager.GetAJob(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    return manager.GetAJob(id);
                }
            }
        }
    }
}
