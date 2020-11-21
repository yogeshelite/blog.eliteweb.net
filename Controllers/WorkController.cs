using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class WorkController : Controller
    {
        // GET: Work
        [HandleError]
        [Route("Work")]
        public ActionResult Work()
        {
            return View();
        }
        [HttpPost]
        [Route("Work")]
        public ActionResult Work(string Email, string Name, long Phone, string Description,string Requirement)
        {
            try
            {
                MailMessage msg = new MailMessage();
                // Add your email address to the recipients
                msg.To.Add("info@elitewebtechnologies.com");
                // Configure the address we are sending the mail from
                MailAddress address = new MailAddress("info@elitewebtechnologies.com");
                msg.From = address;
                msg.Subject = "Contact form ";
                msg.Body = "User Email:-" + Email + "\n User Name:-" + Name + "\n User Phone :-" + Phone + "\nDescription :-" + Description+ "/n Requirement"+ Requirement;

                SmtpClient client = new SmtpClient();
                client.Host = "relay-hosting.secureserver.net";
                client.Port = 25;

                // Send the msg
                client.Send(msg);
                //if (ModelState.IsValid)
                //{
                //    //var SenderEmail = new MailAddress("mukulcityinfomart@gmail.com","EliteWebTechnology");
                //    var ReciverEmail = new MailAddress("info@elitewebtechnologies.com", "Reciver");
                //    //var password = "";
                //    var sub = "Contact Form";
                //    var body = "User Email:-" + Email + "\n User Name:-" + Name + "\n User Company :-" + Company + "\n Message :-" + Message;
                //    var smtp = new SmtpClient
                //    {
                //        Host = "relay-hosting.secureserver.net",
                //        Port = 25,
                //        EnableSsl = false,
                //        DeliveryMethod = SmtpDeliveryMethod.Network,
                //        UseDefaultCredentials = false,
                //        //Credentials = new NetworkCredential(SenderEmail.Address, password)
                //    };
                //    using (var message = new MailMessage(SenderEmail, ReciverEmail) {
                //        Subject = sub,
                //        Body = body
                //    }
                //    )
                //    {
                //        smtp.Send(message);

                //    }
                ViewBag.Error = "Thanks, we will get back to you!";
                return View();
                //}

            }
            catch (Exception Ex)
            {
                ViewBag.Error = "There are some problems sending Email.";
                return View();
            }

        }
    }
}