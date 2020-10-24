using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;

namespace WebApplication1.Controllers
{
    public class CertificateInfoController : Controller
    {
        private MappleDBContext db = new MappleDBContext();

        // GET: CertificateInfo
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        // GET: CertificateInfo/Details/5
        public ActionResult Index(string CertificateNo)
        {

            CertificateInfo certificateInfo = db.GetCertificateInfor(CertificateNo).FirstOrDefault();
            if (certificateInfo == null)
            {
                ViewBag.Message = "Certificate Information not found!";
                return View();
            }
            else
            {
                TempData["CertNumber"] = CertificateNo;
                return RedirectToAction("Details","CertificateInfo");
            }
        }

        public ActionResult Details()
        {
            //string strCertNum = TempData["CertNumber"].ToString();
            string strCertNum = "R-123-4";
            CertificateInfo certificateInfo = db.GetCertificateInfor(strCertNum).FirstOrDefault();
            return View(certificateInfo);
        }

        // GET: CertificateInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificateInfo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CertificateNo,CompanyName,CompanyAddress,Country,Scope,RegistrationDate,ReRegistrationDate,Standard,Status")] CertificateInfo certificateInfo)
        {
            if (ModelState.IsValid)
            {
                db.CertificateInfoes.Add(certificateInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(certificateInfo);
        }

        // GET: CertificateInfo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificateInfo certificateInfo = db.CertificateInfoes.Find(id);
            if (certificateInfo == null)
            {
                return HttpNotFound();
            }
            return View(certificateInfo);
        }

        // POST: CertificateInfo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CertificateNo,CompanyName,CompanyAddress,Country,Scope,RegistrationDate,ReRegistrationDate,Standard,Status")] CertificateInfo certificateInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificateInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(certificateInfo);
        }

        // GET: CertificateInfo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificateInfo certificateInfo = db.CertificateInfoes.Find(id);
            if (certificateInfo == null)
            {
                return HttpNotFound();
            }
            return View(certificateInfo);
        }

        // POST: CertificateInfo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CertificateInfo certificateInfo = db.CertificateInfoes.Find(id);
            db.CertificateInfoes.Remove(certificateInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
