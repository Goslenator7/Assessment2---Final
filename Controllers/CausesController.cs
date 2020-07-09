using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Assessment2___Final.Data;
using Assessment2___Final.Models;

namespace Assessment2___Final.Controllers
{
    public class CausesController : Controller
    {
        private ClickPollDB db = new ClickPollDB();

        // GET: Causes
        public ActionResult Index()
        {
            return View(db.Causes.ToList());
        }

        // GET: Causes/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cause cause = db.Causes.Find(id);
            if (cause == null)
            {
                return HttpNotFound();
            }
            return View(cause);
        }

        // GET: Causes/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Causes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CauseID,Title,Category,Description,Image,Signed")] Cause cause)
        {
            // Set signatures on new cause to 0
            cause.Signed = 0;

            if (ModelState.IsValid)
            {
                db.Causes.Add(cause);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cause);
        }

        // GET: Causes/Edit/5
        // Display only when user is logged in
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cause cause = db.Causes.Find(id);
            if (cause == null)
            {
                return HttpNotFound();
            }
            return View(cause);
        }

        // POST: Causes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CauseID,Title,Category,Description,Image,Signed")] Cause cause)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cause).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cause);
        }

        // GET: Causes/Delete/5
        // Only display option if admin is logged in (User that is assigned admin role)
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cause cause = db.Causes.Find(id);
            if (cause == null)
            {
                return HttpNotFound();
            }
            return View(cause);
        }

        // POST: Causes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cause cause = db.Causes.Find(id);
            db.Causes.Remove(cause);
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

        // When User clicks sign, add a signature to cause
        // Option displayed only when logged in
        [Authorize]
        public ActionResult Sign (int id)
        {
            // Find cause in db based on CauseID
            Cause update = db.Causes.ToList().Find(u => u.CauseID == id);
            // Increment Signatures by 1
            update.Signed += 1;
            // Save changes in db
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}