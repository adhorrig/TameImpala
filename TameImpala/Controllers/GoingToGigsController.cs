using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TameImpala.Models;

namespace TameImpala.Controllers
{
    public class GoingToGigsController : Controller
    {
        private TameImpalaContext db = new TameImpalaContext();

        // GET: GoingToGigs
        public ActionResult Index()
        {
            return View(db.GoingToGigs.ToList());
        }

        // GET: GoingToGigs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoingToGig goingToGig = db.GoingToGigs.Find(id);
            if (goingToGig == null)
            {
                return HttpNotFound();
            }
            return View(goingToGig);
        }

        // GET: GoingToGigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GoingToGigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GoingToGigID,attending,UserID")] GoingToGig goingToGig)
        {
            if (ModelState.IsValid)
            {
                db.GoingToGigs.Add(goingToGig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(goingToGig);
        }

        // GET: GoingToGigs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoingToGig goingToGig = db.GoingToGigs.Find(id);
            if (goingToGig == null)
            {
                return HttpNotFound();
            }
            return View(goingToGig);
        }

        // POST: GoingToGigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GoingToGigID,attending,UserID")] GoingToGig goingToGig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goingToGig).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(goingToGig);
        }

        // GET: GoingToGigs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoingToGig goingToGig = db.GoingToGigs.Find(id);
            if (goingToGig == null)
            {
                return HttpNotFound();
            }
            return View(goingToGig);
        }

        // POST: GoingToGigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GoingToGig goingToGig = db.GoingToGigs.Find(id);
            db.GoingToGigs.Remove(goingToGig);
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
