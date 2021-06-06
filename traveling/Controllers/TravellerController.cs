﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using traveling.Models;
//using traveling.Models.user_s;

namespace traveling.Controllers
{
    public class TravellerController : Controller
    {
        private Database1Entities safari;

          public TravellerController()
        {
           safari = new Database1Entities();
        }
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult profile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult register(user Person)
        {


            _ = safari.users.Add(Person);
            _ = safari.SaveChanges();

            return login(Person);
           // if(Person.userType == "traveller")
             //   return RedirectToAction("Index",   "Traveller");
           // else
             //   return RedirectToAction("Index", "Agency");


        }

        [HttpPost]
        public ActionResult login(user person)
        {

            // var result = safari.user_s.Where(user => user.email == person.email).Select(s => { s.password, s.userID, s.userType});
         
                var result = from user in safari.users
                             where user.username == person.username
                             select user;


                foreach (var x in result)
                {
                    if (x.password == person.password)
                    {

                        Session["user"] = person;
                        if (x.userType == "traveller")
                            return RedirectToAction("Index", "Traveller");
                        else if (x.userType == "agency")
                            return RedirectToAction("Index", "Agency");
                        else
                            return RedirectToAction("Index", "Admin");


                    }

                }
                return RedirectToAction("login");
        }

    }
}