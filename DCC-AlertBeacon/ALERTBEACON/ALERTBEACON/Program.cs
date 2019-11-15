using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALERTBEACON
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Find your Account Sid and Token at twilio.com/console
            // DANGER! This is insecure. See http://twil.io/secure
            const string accountSid = "AC35810413163bba58fc26a448cea156b6";
            const string authToken = "a33c2dfa2620d6384dd55b63561d891";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: "Sample SMS - this is where we input the SMS body message",
                from: new Twilio.Types.PhoneNumber("+15017122661"),
                to: new Twilio.Types.PhoneNumber("+15558675310")
            );

            Console.WriteLine(message.Sid);
        }
    }
}
