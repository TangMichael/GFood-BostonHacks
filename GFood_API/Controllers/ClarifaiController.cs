using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Clarifai.API;
using Clarifai.API.Responses;
using Clarifai.DTOs.Inputs;
using Clarifai.DTOs.Searches;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClarifaiController : Controller
    {
        ClarifaiHandler clarifai;


        // GET api/values/5
        [HttpGet]
        public async Task GetAsync(string search)
        {
            ClarifaiClient client = new ClarifaiClient("dfa26cc77ace4f539eff32c420226fbc");
            var response = await client.SearchInputs(SearchBy.ConceptName("breakfast"))
            .Page(1)
            .ExecuteAsync();

            Console.Write(response);
         
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
