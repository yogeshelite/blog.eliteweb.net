using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using EliteWeb.Models;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login model)
        {
            using (var context = new EWT_PrivateSQREntities1())
            {
                bool isValid = context.Login.Any(x => x.UserName == model.UserName && x.Password == model.Password);
                if (isValid)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Dashboard", "Admin");
                }
                ModelState.AddModelError("", "Please Enter The Valid Credential.");
                return View();
            }
        }
        [Authorize]
        public ActionResult Dashboard()
        {
            ViewBag.header = "Dashborad";
            return View();
        }
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Admin");
        }
    }
}