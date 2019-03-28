using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Presentation_layer_Web_API_.Models;

namespace Presentation_layer_Web_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        // GET api/values
        /// <summary>
        /// Get all companies
        /// </summary>
        [HttpGet]
        public IEnumerable<CompanyModel> GetCompanies()
        {
            using (DbManager dbManager = new DbManager())
            {
                return dbManager.GetAllCompanies();
            }
        }

        // GET api/values/5
        /// <summary>
        /// Get a company by Id
        /// </summary>
        [HttpGet("{id}")]
        public ActionResult<CompanyModel> GetACompany(int id)
        {
            using (DbManager manager = new DbManager())
            {
                if (manager.GetCompanyById(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    return manager.GetCompanyById(id);
                }
            }
        }
    }
}
