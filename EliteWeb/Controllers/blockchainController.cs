using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    public class blockchainController : Controller
    {
        // GET: blockchain
        [HandleError]
        [Route("blockchain")]
        public ActionResult blockchain()
        {
            return View();
        }
    }
}