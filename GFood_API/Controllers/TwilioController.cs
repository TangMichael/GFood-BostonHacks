using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GFood_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioController : Controller
    {
        TwilioServices service;

        public TwilioController() {
            service = new TwilioServices();
        }

        [HttpPost]
        public void sms(string location, string phone)
        {
            service.setToPhone(phone);
            service.sendSMS(location);
        }
    }

}
