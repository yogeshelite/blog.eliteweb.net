using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EliteWeb.Models;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class careerController : Controller
    {
        private EWT_PrivateSQREntities1 db = new EWT_PrivateSQREntities1();
        // GET: career
        [HandleError]
        [Route("Career")]
        public ActionResult career()
        {
            db.Database.CommandTimeout = 50;
            return View(db.Career.ToList());
        }
        public ActionResult career_details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            db.Database.CommandTimeout = 50;
            Career career = db.Career.Find(id);
            if (career == null)
            {
                return HttpNotFound();
            }
            return View(career);
        }
    }
}