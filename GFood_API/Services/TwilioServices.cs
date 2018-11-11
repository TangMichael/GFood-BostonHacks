using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
namespace GFood_API
{
    public class TwilioServices
    {

        // Find your Account Sid and Token at twilio.com/console
        const string accountSid = "ACea129922a894f9e4711ca95c4f6b3e7c";
        const string authToken = "c02f00b416797f886f7dda8493eeaddf";

        public string fromPhone = "+16042458428";
        public string toPhone = "+5142418022"; 

        public TwilioServices()
        {
            TwilioClient.Init(accountSid, authToken);
        }

        public void setToPhone(string phone) {
            this.toPhone = phone;
        }

        public void sendMessage(string input) {
            var message = MessageResource.Create(
                            body: input,
                            from: new Twilio.Types.PhoneNumber("+16042458428"),
                to: new Twilio.Types.PhoneNumber(toPhone)
                        );

            Console.WriteLine(message.Sid);
        }

    }
}
