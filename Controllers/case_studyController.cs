using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class case_studyController : Controller
    {
        // GET: case_study
        [HandleError]
        [Route("case_study_details")]
        public ActionResult case_study_details()
        {
            return View();
        }
        [Route("case_study_listing")]
        public ActionResult case_study_listing()
        {
            return View();
        }
    }
}