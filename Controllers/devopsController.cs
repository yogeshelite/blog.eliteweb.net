using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class devopsController : Controller
    {
        // GET: devops
        [HandleError]
        [Route("devops")]
        public ActionResult devops()
        {
            return View();
        }
    }
}