using PNP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace PNP.Controllers
{
    public class LocationController : Controller
    {
        private PNPContext db = new PNPContext();
        // GET: Location
        public ActionResult Index()
        {
            return View(db.Locations.ToList());
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
        public ActionResult Create([Bind(Include = "pnpLocationID,pnpLocationName,pnpLocationStreetAddress,pnpLocationSuburbAddress,pnpLocationCodeAddress,pnpLocationCoordinates")] PnpLocation pnpLocation)
        {
            if (ModelState.IsValid)
            {
                db.Locations.Add(pnpLocation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pnpLocation);
        }



    }
}