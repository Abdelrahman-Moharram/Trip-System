using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveling.Models;
using System.IO;
using traveling.viewModel;

namespace traveling.Controllers
{
    public class AgencyController : Controller
    {

        Database1Entities db;

        public AgencyController()
        {
            db = new Database1Entities();
        }
        // GET: Agency
     
        public ActionResult Index()
        {

          
            return View();
        }




        [HttpGet]
        public ActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreatePost(post p,user us, HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {

                string path = "";
                if (file.FileName.Length > 0)
                {
                    path = "~/images/" + Path.GetFileName(file.FileName);
                    file.SaveAs(Server.MapPath(path));
                }

                p.tripImg = path;

                p.uid =us.Id;

                _ = db.posts.Add(p); 
                _ = db.SaveChanges();
                ViewBag.message = "Post created Successfully";
                return RedirectToAction("Index");
            }
            return View(p);
        }


        public ActionResult MyPosts(int id)
        {
            //  id = this.id;

            var resultDetails = db.posts.ToList();
            return View(resultDetails);
        }





    }
}