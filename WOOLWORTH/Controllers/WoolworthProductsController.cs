using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WOOLWORTH.Models;

namespace WOOLWORTH.Controllers
{
    public class WoolworthProductsController : Controller
    {
        private WOOLWORTHContext db = new WOOLWORTHContext();

        // GET: WoolworthProducts
        public ActionResult Index()
        {
            return View(db.WoolworthProducts.ToList());
        }

        // GET: WoolworthProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WoolworthProducts woolworthProducts = db.WoolworthProducts.Find(id);
            if (woolworthProducts == null)
            {
                return HttpNotFound();
            }
            return View(woolworthProducts);
        }

        // GET: WoolworthProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WoolworthProducts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "productID,productName,productImage,ProductPrice,productDropPercent,productDesc,productDateEndPromo")] WoolworthProducts woolworthProducts)
        {
            if (ModelState.IsValid)
            {
                db.WoolworthProducts.Add(woolworthProducts);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(woolworthProducts);
        }

        // GET: WoolworthProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WoolworthProducts woolworthProducts = db.WoolworthProducts.Find(id);
            if (woolworthProducts == null)
            {
                return HttpNotFound();
            }
            return View(woolworthProducts);
        }

        // POST: WoolworthProducts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "productID,productName,productImage,ProductPrice,productDropPercent,productDesc,productDateEndPromo")] WoolworthProducts woolworthProducts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(woolworthProducts).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(woolworthProducts);
        }

        // GET: WoolworthProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WoolworthProducts woolworthProducts = db.WoolworthProducts.Find(id);
            if (woolworthProducts == null)
            {
                return HttpNotFound();
            }
            return View(woolworthProducts);
        }

        // POST: WoolworthProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WoolworthProducts woolworthProducts = db.WoolworthProducts.Find(id);
            db.WoolworthProducts.Remove(woolworthProducts);
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
