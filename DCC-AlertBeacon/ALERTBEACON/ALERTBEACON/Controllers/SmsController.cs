using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Twilio.TwiML;
using Twilio.AspNet.Mvc;
using ALERTBEACON.Models;

namespace ALERTBEACON.Controllers
{
    public class SmsController : TwilioController
    {
        ApplicationDbContext context;

        public SmsController()
        {
            context = new ApplicationDbContext();
        }

        public ActionResult SendSms(Observer observer)
        {
            if (observer.LicensePlate == observer.LicensePlate) //logic for db query resulting in a license plate # match - still need to update
            {
                var accountSid = APIKEY.accountSid;
                var authToken = APIKEY.authToken;
                TwilioClient.Init(accountSid, authToken); 

                var from = new PhoneNumber(APIKEY.PhoneNumber);
                var to= new PhoneNumber("+14145205406");

                var message = MessageResource.Create(
                    to: to,
                    from: from,
                    body: "Welcome to Alert Beacon");
                return Content(message.Sid);
            }

            return View(observer);
        }
    }
}