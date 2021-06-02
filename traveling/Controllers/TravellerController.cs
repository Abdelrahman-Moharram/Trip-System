using System;
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
        private safariEntities2 safari;

          public TravellerController()
        {
           safari = new safariEntities2();
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
        public ActionResult register(user_s Person)
        {


            safari.user_s.Add(Person);
            safari.SaveChanges();
            if(Person.userType == "traveller")
                return RedirectToAction("Index",   "Traveller");
            else
                return RedirectToAction("Index", "Agency");


        }

        [HttpPost]
        public ActionResult login(user_s person)
        {

            // var result = safari.user_s.Where(user => user.email == person.email).Select(s => { s.password, s.userID, s.userType});
            var result = from user in safari.user_s
                         where user.email == person.email
                         select new { user.userID, user.password, user.userType };




            foreach (var x in result)
            {
                if (x.password == person.password)
                {
                    if (x.userType == "traveller")
                        return RedirectToAction("Index", "Traveller");
                    else if (x.userType == "agency")
                        return RedirectToAction("Index", "Agency");
                    else
                        return RedirectToAction("Index", "Admin");

                }   

            }
                return RedirectToAction("loginError");


        }

    }
}