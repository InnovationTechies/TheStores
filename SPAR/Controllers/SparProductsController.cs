using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SPAR.Models;

namespace SPAR.Controllers
{
    public class SparProductsController : Controller
    {
        private SPARContext db = new SPARContext();

        // GET: SparProducts
        public ActionResult Index()
        {
            return View(db.SparProducts.ToList());
        }

        // GET: SparProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SparProducts sparProducts = db.SparProducts.Find(id);
            if (sparProducts == null)
            {
                return HttpNotFound();
            }
            return View(sparProducts);
        }

        // GET: SparProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SparProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "productID,productName,productImage,productDropPercent,productDescription,productDateEndPromo")] SparProducts sparProducts)
        {
            if (ModelState.IsValid)
            {
                db.SparProducts.Add(sparProducts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sparProducts);
        }

        // GET: SparProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SparProducts sparProducts = db.SparProducts.Find(id);
            if (sparProducts == null)
            {
                return HttpNotFound();
            }
            return View(sparProducts);
        }

        // POST: SparProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "productID,productName,productImage,productDropPercent,productDescription,productDateEndPromo")] SparProducts sparProducts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sparProducts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sparProducts);
        }

        // GET: SparProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SparProducts sparProducts = db.SparProducts.Find(id);
            if (sparProducts == null)
            {
                return HttpNotFound();
            }
            return View(sparProducts);
        }

        // POST: SparProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SparProducts sparProducts = db.SparProducts.Find(id);
            db.SparProducts.Remove(sparProducts);
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
