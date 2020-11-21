using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        [HandleError]
        [Route("services")]
        public ActionResult services()
        {
            return View();
        }
    }
}