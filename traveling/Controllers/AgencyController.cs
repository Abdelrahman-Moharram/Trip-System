﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveling.Models;
using System.IO;
namespace traveling.Controllers
{
    public class AgencyController : Controller
    {

        safariEntities2 db;

        public AgencyController()
        {
            db = new safariEntities2();
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
        public ActionResult CreatePost(trip trp , HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {

                string path = "";
                if (file.FileName.Length > 0)
                {
                    path = "~/images/" + Path.GetFileName(file.FileName);
                    file.SaveAs(Server.MapPath(path));
                }
               
                trp.tripImagePath = path;



                _ = db.trips.Add(trp);
                _ = db.SaveChanges();
                ViewBag.message = "Post created Successfully";
                return RedirectToAction("Index");
            }
            return View(trp);
        }

        public ActionResult MyPosts()
        {
            var resultDetails = db.trips.ToList();
            return View(resultDetails);
        }


       


    }
}