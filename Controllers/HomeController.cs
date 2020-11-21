using EliteWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class HomeController : Controller
    {
        private EWT_PrivateSQREntities1 db = new EWT_PrivateSQREntities1();
        [HandleError]
        public ActionResult Index()
        {
            db.Database.CommandTimeout = 50;
            var list = db.BlogTable.ToList();
            return View(list);
        }
    }
}