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
    public class FavoriteGigsController : Controller
    {
        private TameImpalaContext db = new TameImpalaContext();

        // GET: FavoriteGigs
        public ActionResult Index()
        {
            return View(db.FavoriteGigs.ToList());
        }

        // GET: FavoriteGigs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FavoriteGig favoriteGig = db.FavoriteGigs.Find(id);
            if (favoriteGig == null)
            {
                return HttpNotFound();
            }
            return View(favoriteGig);
        }

        // GET: FavoriteGigs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FavoriteGigs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FavoriteGigID,Location,Date,Description,Title,UserID")] FavoriteGig favoriteGig)
        {
            if (ModelState.IsValid)
            {
                db.FavoriteGigs.Add(favoriteGig);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(favoriteGig);
        }

        // GET: FavoriteGigs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FavoriteGig favoriteGig = db.FavoriteGigs.Find(id);
            if (favoriteGig == null)
            {
                return HttpNotFound();
            }
            return View(favoriteGig);
        }

        // POST: FavoriteGigs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FavoriteGigID,Location,Date,Description,Title,UserID")] FavoriteGig favoriteGig)
        {
            if (ModelState.IsValid)
            {
                db.Entry(favoriteGig).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(favoriteGig);
        }

        // GET: FavoriteGigs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FavoriteGig favoriteGig = db.FavoriteGigs.Find(id);
            if (favoriteGig == null)
            {
                return HttpNotFound();
            }
            return View(favoriteGig);
        }

        // POST: FavoriteGigs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FavoriteGig favoriteGig = db.FavoriteGigs.Find(id);
            db.FavoriteGigs.Remove(favoriteGig);
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
