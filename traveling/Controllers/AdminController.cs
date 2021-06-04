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
        // ايه يسطا جاهز للشغل
        private Database1Entities safari;

        public AdminController()
        {
            safari = new Database1Entities();
        }
        // GET: Admin
        public ActionResult Index()
        {

            var result = safari.users.ToList();

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

            var returnedUser = safari.users.SingleOrDefault(c => c.Id == id);

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
            int id = model.user.Id;
           
    
            var returnedUser = safari.users.SingleOrDefault(c => c.Id == id);

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
                from user in safari.users
                where user.Id == id
                select user;

            foreach (var user in returnedUsers)
            {


                _ = safari.users.Remove(user);
               

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