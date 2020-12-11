using EliteWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EliteWeb.Controllers
{
    [Authorize]
    public class AdminBlogController : Controller
    {
        private EWT_PrivateSQREntities1 db = new EWT_PrivateSQREntities1();

        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.header = "All Blogs";
            db.Database.CommandTimeout = 50;
            return View(db.BlogTable.ToList());
        }

        // GET: Blog/Details/5
        public ActionResult Details(long? id)
        {
            db.Database.CommandTimeout = 50;
            ViewBag.header = "Blog Details";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogTable blogTable = db.BlogTable.Find(id);
            if (blogTable == null)
            {
                return HttpNotFound();
            }
            return View(blogTable);
        }

        // GET: Blog/Create
        public ActionResult Create()
        {
            db.Database.CommandTimeout = 50;
            ViewBag.header = "Add New Blog";
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Blog,Date,Category,Heading,ShortDiscription,FeaturedImage")] BlogTable blogTable)
        {
            db.Database.CommandTimeout = 50;
            if (ModelState.IsValid)
            {
                db.BlogTable.Add(blogTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blogTable);
        }

        // GET: Blog/Edit/5
        public ActionResult Edit(long? id)
        {
            db.Database.CommandTimeout = 50;
            ViewBag.header = "Edit Blog";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogTable blogTable = db.BlogTable.Find(id);
            if (blogTable == null)
            {
                return HttpNotFound();
            }
            ViewBag.Featuredimage = blogTable.FeaturedImage;
            return View(blogTable);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Blog,Date,Category,Heading,ShortDiscription,FeaturedImage")] BlogTable blogTable)
        {
            db.Database.CommandTimeout = 50;
            if (ModelState.IsValid)
            {
                db.Entry(blogTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogTable);
        }

        // GET: Blog/Delete/5
        public ActionResult Delete(long? id)
        {
            db.Database.CommandTimeout = 50;
            ViewBag.header = "Delete Blog";
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogTable blogTable = db.BlogTable.Find(id);
            if (blogTable == null)
            {
                return HttpNotFound();
            }
            return View(blogTable);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            db.Database.CommandTimeout = 50;
            BlogTable blogTable = db.BlogTable.Find(id);
            db.BlogTable.Remove(blogTable);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}