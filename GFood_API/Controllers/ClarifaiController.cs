using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Clarifai.API;
using Clarifai.API.Responses;
using Clarifai.DTOs.Inputs;
using Clarifai.DTOs.Searches;
using Microsoft.AspNetCore.Cors;

using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [EnableCors(origins: "http://localhost:3000")]
    public class ClarifaiController : Controller
    {
        ClarifaiHandler clarifai;

        public ClarifaiController()
        {
            clarifai = new ClarifaiHandler();
        }

        // GET api/values/5
        [HttpPost]
        public async Task<string> GetAsync([FromBody]string search)
        {
            var response = await clarifai.SearchByConcept(search);
            var x = JsonConvert.SerializeObject((Object)response);
            // get the response body and transform it into temp object
            var z = JObject.Parse(response.RawBody);
            // access the url for the first hit
            // need to do for loop to get all the hits
            string[] arr = new string[1];
            arr[0] = z["hits"][0]["input"]["data"]["image"]["url"].ToString();

            return JsonConvert.SerializeObject(arr);
        }
    }
}
