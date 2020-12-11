using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class industryController : Controller
    {
        // GET: industry
        [HandleError]
        [Route("industry")]
        public ActionResult industry()
        {
            return View();
        }
        [Route("industry_detail")]
        public ActionResult industry_detail()
        {
            return View();
        }
        [Route("industry_detail4")]
        public ActionResult industry_detail4()
        {
            return View();
        }
    }
}