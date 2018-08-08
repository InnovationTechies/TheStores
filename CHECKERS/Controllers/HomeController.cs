using CHECKERS.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHECKERS.Controllers
{
    public class HomeController : Controller
    {
        CHECKERSContext db = new CHECKERSContext();

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc, HttpPostedFileBase file)
        {
            Products tbl = new Products();
            var allowedExtensions = new[] {
            ".Jpg", ".png", ".jpg", "jpeg"
        };
            tbl.productID = int.Parse(fc["Id"]);
            tbl.productImage = file.ToString(); //getting complete url  
            tbl.productName = fc["Name"].ToString();
            var fileName = Path.GetFileName(file.FileName); //getting only file name(ex-ganesh.jpg)  
            var ext = Path.GetExtension(file.FileName); //getting the extension(ex-.jpg)  
            if (allowedExtensions.Contains(ext)) //check what type of extension  
            {
                string name = Path.GetFileNameWithoutExtension(fileName); //getting file name without extension  
                string myfile = name + "_" + tbl.productID + ext; //appending the name with id  
                                                                  // store the file inside ~/project folder(Img)  
                var path = Path.Combine(Server.MapPath("~/fonts/images/"), myfile);
                tbl.productImage = path;
                db.Products.Add(tbl);
                db.SaveChanges();
                file.SaveAs(path);
            }
            else
            {
                ViewBag.message = "Please choose only Image file";
            }
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}