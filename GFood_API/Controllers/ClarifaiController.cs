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
using Newtonsoft.Json.Linq;

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
            // get the response body and transform it into temp object
            var z = JObject.Parse(response.RawBody);
            // access the url for the first hit
            // need to do for loop to get all the hits
            z["hits"][0]["input"]["data"]["image"]["url"].ToString();



        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
