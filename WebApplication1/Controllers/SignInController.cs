using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class SignInController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin user)
        {
            if (IsLoginSuccess(user.UserID, user.Password))
            {
                Session["UserID"] = user.UserID;
                return RedirectToAction("Index", "CertificationLists");
            }
            else
            {
                ViewData["Message"] = "Invalid User!";
                return View();
            }
        }

        [NonAction]
        private bool IsLoginSuccess(string user, string pwd)
        {

            MappleDBContext MappleDB = new MappleDBContext();
            var userDetails = MappleDB.MappleUsers.Where(p => p.UserName == user && p.Password == pwd).SingleOrDefault();
            if (userDetails != null)
            {
                return true;
            }
            else
            {

                return false;
            }

        }

    }
}