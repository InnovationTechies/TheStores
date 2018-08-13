using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PNP.Models;

namespace PNP.Controllers
{
    public class ProductCatagoriesController : Controller
    {
        private ProductCatagoriesContext db = new ProductCatagoriesContext();

        // GET: ProductCatagories
        public ActionResult Index()
        {
            return View(db.ProductCatagories.ToList());
        }

        // GET: ProductCatagories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductCatagory productCatagory = db.ProductCatagories.Find(id);
            if (productCatagory == null)
            {
                return HttpNotFound();
            }
            return View(productCatagory);
        }

        // GET: ProductCatagories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductCatagories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "catagoryID,catagoryName,catagoryDesc")] ProductCatagory productCatagory)
        {
            if (ModelState.IsValid)
            {
                db.ProductCatagories.Add(productCatagory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productCatagory);
        }

        // GET: ProductCatagories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductCatagory productCatagory = db.ProductCatagories.Find(id);
            if (productCatagory == null)
            {
                return HttpNotFound();
            }
            return View(productCatagory);
        }

        // POST: ProductCatagories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "catagoryID,catagoryName,catagoryDesc")] ProductCatagory productCatagory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productCatagory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productCatagory);
        }

        // GET: ProductCatagories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductCatagory productCatagory = db.ProductCatagories.Find(id);
            if (productCatagory == null)
            {
                return HttpNotFound();
            }
            return View(productCatagory);
        }

        // POST: ProductCatagories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductCatagory productCatagory = db.ProductCatagories.Find(id);
            db.ProductCatagories.Remove(productCatagory);
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
