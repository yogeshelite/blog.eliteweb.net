using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class Our_TeamController : Controller
    {
        // GET: Our_Team
        [Route("Our_Team")]
        public ActionResult Our_Team()
        {
            return View();
        }
    }
}