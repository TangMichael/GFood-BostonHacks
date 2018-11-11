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

        public ClarifaiController() {
            clarifai = new ClarifaiHandler();
        }

        // GET api/values/5
        [HttpGet]
        public async Task GetAsync(string concept)
        {
            var response = clarifai.SearchByConcept("breakfast");
            var x = JsonConvert.SerializeObject((Object)response);
            Console.Write(JsonConvert.DeserializeObject(x));
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
    }
}
