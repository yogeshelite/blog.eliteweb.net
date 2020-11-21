using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        // GET: PrivacyPolicy
        [HandleError]
        [Route("PrivacyPolicy")]
        public ActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}