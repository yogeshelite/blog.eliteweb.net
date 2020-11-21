using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class prototyping_uxController : Controller
    {
        // GET: prototyping_ux
        [HandleError]
        [Route("prototyping_ux")]
        public ActionResult prototyping_ux()
        {
            return View();
        }
    }
}