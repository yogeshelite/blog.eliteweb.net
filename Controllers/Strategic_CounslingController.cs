using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class Strategic_CounslingController : Controller
    {
        // GET: Strategic_Counsling
        [Route("Strategic_Counsling")]
        public ActionResult Strategic_Counsling()
        {
            return View();
        }
    }
}