using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace traveling.Controllers
{
    public class AgencyController : Controller
    {
        // GET: Agency
        public ActionResult Index()
        {
            return View();
        }



        public ActionResult MyPosts()
        {
            return View();
        }
    }
}