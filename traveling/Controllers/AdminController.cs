using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveling.Models;
using traveling.viewModel;

namespace traveling.Controllers
{
    public class AdminController : Controller
    {
        private safariEntities2 safari;

        public AdminController()
        {
            safari = new safariEntities2();
        }
        // GET: Admin
        public ActionResult Index()
        {

            var result = safari.user_s.ToList();

            var Viewuser = new viewUserModel
            {
                users = result
            };

            return View(Viewuser);
        }

        public ActionResult PendingPosts()
        {
            return View();
        }

        public ActionResult UpdateUserInfo(int id)
        {

            var returnedUser = safari.user_s.SingleOrDefault(c => c.userID == id);

          //  var returnedUsers =
          //    from user in safari.user_s
          //   where user.userID == id
          //   select user;

            var viewModel = new userUpdateView {
                user = returnedUser
            };


            return View(viewModel);
        }
        public ActionResult update(userUpdateView model)
        {
            int id = model.user.userID;
           
    
            var returnedUser = safari.user_s.SingleOrDefault(c => c.userID == id);

            returnedUser.fname = model.user.fname;
            returnedUser.lname = model.user.lname;
            returnedUser.phone = model.user.phone;
            returnedUser.email = model.user.email;


            _ = safari.SaveChanges();


            return View();

        }
        [HttpGet]
        public ActionResult removeUser(int id)
        {
            // Query the database for the rows to be deleted.
            var returnedUsers =
                from user in safari.user_s
                where user.userID == id
                select user;

            foreach (var user in returnedUsers)
            {


                _ = safari.user_s.Remove(user);
               

            }

            try
            {
                _ = safari.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }

            return View();
        }


    }
}