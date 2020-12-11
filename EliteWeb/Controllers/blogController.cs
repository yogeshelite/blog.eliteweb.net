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
    public class blogController : Controller
    {
        private EWT_PrivateSQREntities1 db = new EWT_PrivateSQREntities1();
        // GET: blog
        [HandleError]
        [Route("Blog")]
        public ActionResult blog()
        {
            db.Database.CommandTimeout = 50;
            return View(db.BlogTable.ToList());
        }
        public ActionResult blog_Details(long? id)
        {
            //var id = RouteData.Values["id"].ToString();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogTable blogTable = db.BlogTable.Find(id);
            if (blogTable == null)
            {
                return HttpNotFound();
            }
            db.Database.CommandTimeout = 50;
            ViewBag.bloglist = db.BlogTable.ToList();
            return View(blogTable);
        }
    }
}