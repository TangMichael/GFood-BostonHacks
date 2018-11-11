using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio.AspNet.Common;
using Twilio.AspNet.Mvc;
using Twilio.TwiML;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SmsController : Controller
    {
       
        [HttpGet]
        public void GetSms(string location)
        {
                 TwilioServices.sms(location);
        }
    }
}
