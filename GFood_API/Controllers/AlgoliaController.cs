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
<<<<<<< HEAD
        [HttpGet]
        public List<string> getUrl()
        {
            return AlgoliaService.GetPictureLocations();
        }

=======
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

>>>>>>> f85e245b24aeda5c5872ec11538814b793e4d24f
    }
}
