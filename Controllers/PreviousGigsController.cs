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
    public class PreviousGigsController : Controller
    {
        private TameImpalaContext db = new TameImpalaContext();

        // GET: PreviousGigs
        public ActionResult Index()
        {
            return View(db.PreviousGigs.ToList());
        }

        // GET: PreviousGigs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreviousGig previousGig = db.PreviousGigs.Find(id);
            if (previousGig == null)
            {
                return HttpNotFound();
            }
            return View(previousGig);
        }

        // GET: PreviousGigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PreviousGigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PreviousGigID,Location,Date,Description,Title,Rating,UserID")] PreviousGig previousGig)
        {
            if (ModelState.IsValid)
            {
                db.PreviousGigs.Add(previousGig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(previousGig);
        }

        // GET: PreviousGigs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreviousGig previousGig = db.PreviousGigs.Find(id);
            if (previousGig == null)
            {
                return HttpNotFound();
            }
            return View(previousGig);
        }

        // POST: PreviousGigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PreviousGigID,Location,Date,Description,Title,Rating,UserID")] PreviousGig previousGig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(previousGig).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(previousGig);
        }

        // GET: PreviousGigs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreviousGig previousGig = db.PreviousGigs.Find(id);
            if (previousGig == null)
            {
                return HttpNotFound();
            }
            return View(previousGig);
        }

        // POST: PreviousGigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PreviousGig previousGig = db.PreviousGigs.Find(id);
            db.PreviousGigs.Remove(previousGig);
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
