using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace GFood_API
{
    public class TwilioServices
    {
   
       public static void  sms(string location) { 
            // Find your Account Sid and Token at twilio.com/console
            const string accountSid = "ACea129922a894f9e4711ca95c4f6b3e7c";
            const string authToken = "c02f00b416797f886f7dda8493eeaddf";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Restaurant is located at " + location,
                from: new Twilio.Types.PhoneNumber("+16042458428"),
                to: new Twilio.Types.PhoneNumber("+14389854760")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
