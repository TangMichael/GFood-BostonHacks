using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clarifai.API.Responses;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClarifaiController : Controller
    {
        ClarifaiHandler clarifai;

        // GET: /<controller>/
        public IActionResult Index()
        {
            clarifai = new ClarifaiHandler();
            return View();
        }
        // GET api/values/5
        [HttpPost]
        public ClarifaiResponse<string> getSearchedConcept([FromBody]string search)
        {
            return clarifai.searchByConcept(search);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
