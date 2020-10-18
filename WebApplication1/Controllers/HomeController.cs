using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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