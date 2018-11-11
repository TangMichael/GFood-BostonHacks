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
        ClarifaiService clarifai;
        AlgoliaService algoliaService;
        public static List<string> url_list;
       
        public ClarifaiController()
        {
            clarifai = new ClarifaiService();
            algoliaService = new AlgoliaService();
        }

        // GET api/values/5
        [HttpPost]
        public Task<List<JObject>> Get([FromBody]string search)
        {
            return clarifai.UrlWithAddressAsync(search);
        }
    }
}
