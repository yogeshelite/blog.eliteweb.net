using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class about_usController : Controller
    {
        // GET: about_us
        [HandleError]
        [Route("About_us")]
        public ActionResult about_us()
        {
            return View();
        }
    }
}