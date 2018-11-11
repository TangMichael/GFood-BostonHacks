using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;


namespace GFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlgoliaController : Controller
    {
        AlgoliaService service;

        public AlgoliaController()
        {
            service = new AlgoliaService();
        }

        //photo id
        [HttpGet("{id}")]
        public JObject GetBusiness(string photoID)
        {
            var businessID = service.GetBusinessIDFromPhotoID(photoID);
            return service.GetBusinessFromID(businessID);
        }

    }
}
