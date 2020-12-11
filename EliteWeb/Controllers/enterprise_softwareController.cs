using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class enterprise_softwareController : Controller
    {
        // GET: enterprise_software
        [HandleError]
        [Route("enterprise_software")]
        public ActionResult enterprise_software()
        {
            return View();
        }
    }
}