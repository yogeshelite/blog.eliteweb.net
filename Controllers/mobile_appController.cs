using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class mobile_appController : Controller
    {
        // GET: mobile_app
        [HandleError]
        [Route("mobile_app_development")]
        public ActionResult mobile_app_development()
        {
            return View();
        }
    }
}