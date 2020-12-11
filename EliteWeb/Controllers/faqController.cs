using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class faqController : Controller
    {
        // GET: faq
        [HandleError]
        [Route("faq")]
        public ActionResult faq()
        {
            return View();
        }
    }
}