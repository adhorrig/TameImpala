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
    public class UpcomingGigsController : Controller
    {
        private TameImpalaContext db = new TameImpalaContext();

        // GET: UpcomingGigs
        public ActionResult Index()
        {
            return View(db.UpcomingGigs.ToList());
        }

        public ActionResult Search()
        {
            return View(db.UpcomingGigs.ToList());
        }
        // GET: UpcomingGigs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpcomingGig upcomingGig = db.UpcomingGigs.Find(id);
            if (upcomingGig == null)
            {
                return HttpNotFound();
            }
            return View(upcomingGig);
        }

        // GET: UpcomingGigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UpcomingGigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UpcomingGigID,Location,Price,Date,Description,Title")] UpcomingGig upcomingGig)
        {
            if (ModelState.IsValid)
            {
                db.UpcomingGigs.Add(upcomingGig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(upcomingGig);
        }

        // GET: UpcomingGigs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpcomingGig upcomingGig = db.UpcomingGigs.Find(id);
            if (upcomingGig == null)
            {
                return HttpNotFound();
            }
            return View(upcomingGig);
        }

        // POST: UpcomingGigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UpcomingGigID,Location,Price,Date,Description,Title")] UpcomingGig upcomingGig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(upcomingGig).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(upcomingGig);
        }

        // GET: UpcomingGigs/Delete/5
        [Authorize(Users = "admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UpcomingGig upcomingGig = db.UpcomingGigs.Find(id);
            if (upcomingGig == null)
            {
                return HttpNotFound();
            }
            return View(upcomingGig);
        }

        // POST: UpcomingGigs/Delete/5
        [Authorize(Users = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UpcomingGig upcomingGig = db.UpcomingGigs.Find(id);
            db.UpcomingGigs.Remove(upcomingGig);
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
