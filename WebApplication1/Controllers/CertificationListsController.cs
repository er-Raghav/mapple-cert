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
    public class CertificationListsController : Controller
    {
        private MappleDBContext db = new MappleDBContext();

        // GET: CertificationLists
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Index(CertificationList certList)
        {
            
            string strSession = Session["UserID"].ToString();
            CertificationList certificationList = db.CertificationLists.Where(c => c.CertName == certList.CertName && certList.UserID == strSession).FirstOrDefault();
            return View(certList);

        }

        // GET: CertificationLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificationList certificationList = db.CertificationLists.Find(id);
            if (certificationList == null)
            {
                return HttpNotFound();
            }
            return View(certificationList);
        }

        // GET: CertificationLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CertificationLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CertName,UserID")] CertificationList certificationList)
        {
            if (ModelState.IsValid)
            {
                db.CertificationLists.Add(certificationList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(certificationList);
        }

        // GET: CertificationLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificationList certificationList = db.CertificationLists.Find(id);
            if (certificationList == null)
            {
                return HttpNotFound();
            }
            return View(certificationList);
        }

        // POST: CertificationLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CertName,UserID")] CertificationList certificationList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(certificationList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(certificationList);
        }

        // GET: CertificationLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CertificationList certificationList = db.CertificationLists.Find(id);
            if (certificationList == null)
            {
                return HttpNotFound();
            }
            return View(certificationList);
        }

        // POST: CertificationLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CertificationList certificationList = db.CertificationLists.Find(id);
            db.CertificationLists.Remove(certificationList);
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
