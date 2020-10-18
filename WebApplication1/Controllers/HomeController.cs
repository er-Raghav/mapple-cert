using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        private MappleDBContext db = new MappleDBContext();
        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ContactU cUs = new ContactU();
                    cUs.Name = contact.Name;
                    cUs.Message = contact.Message;
                    cUs.Subject = contact.Subject;
                    cUs.Email = contact.Email;

                    db.ContactUS.Add(cUs);
                    db.SaveChanges();

                    ViewBag.ShowMessage = "Thank you! We will reach you soon.";
                    contact.Message = string.Empty;
                    contact.Email = string.Empty;
                    contact.Name = string.Empty;
                    contact.Subject = string.Empty;
                }
            }
            catch (Exception)
            {

                throw;
            }


            return View(contact);
        }

        public ActionResult Logout()
        {

            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }


        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult BlogDetails()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Elements()
        {
            ViewBag.Message = "Elements";

            return View();
        }

        public ActionResult Blog()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ISO9001()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult ISO10002()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult ISO13485()
        {
            ViewBag.Message = "";

            return View();

        }
        public ActionResult ISO14001()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult GOSTRCertification()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult GoodManufacturingPractice()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult ISO29990()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult ISO27001()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult ISO45001()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult OHSAS18001()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult ISO37001()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult ISO50001()
        {
            ViewBag.Message = "";

            return View();
        }
        public ActionResult ACCREDITATION()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}