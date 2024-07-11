using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NgVanDuoc2210900016.Models;

namespace NgVanDuoc2210900016.Controllers
{
    public class NVD_TACGIAController : Controller
    {
        private NgVanDuoc_2210900016Entities db = new NgVanDuoc_2210900016Entities();

        // GET: NVD_TACGIA
        public ActionResult NvdIndex()
        {
            return View(db.NVD_TACGIA.ToList());
        }

        // GET: NVD_TACGIA/Details/5
        public ActionResult NvdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVD_TACGIA nVD_TACGIA = db.NVD_TACGIA.Find(id);
            if (nVD_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nVD_TACGIA);
        }

        // GET: NVD_TACGIA/Create
        public ActionResult NvdCreate()
        {
            return View();
        }

        // POST: NVD_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvdCreate([Bind(Include = "Nvd_MaTG,Nvd_TenTacGia")] NVD_TACGIA nVD_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.NVD_TACGIA.Add(nVD_TACGIA);
                db.SaveChanges();
                return RedirectToAction("NvdIndex");
            }

            return View(nVD_TACGIA);
        }

        // GET: NVD_TACGIA/Edit/5
        public ActionResult NvdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVD_TACGIA nVD_TACGIA = db.NVD_TACGIA.Find(id);
            if (nVD_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nVD_TACGIA);
        }

        // POST: NVD_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvdEdit([Bind(Include = "Nvd_MaTG,Nvd_TenTacGia")] NVD_TACGIA nVD_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nVD_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvdIndex");
            }
            return View(nVD_TACGIA);
        }

        // GET: NVD_TACGIA/Delete/5
        public ActionResult NvdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVD_TACGIA nVD_TACGIA = db.NVD_TACGIA.Find(id);
            if (nVD_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nVD_TACGIA);
        }

        // POST: NVD_TACGIA/Delete/5
        [HttpPost, ActionName("NvdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NVD_TACGIA nVD_TACGIA = db.NVD_TACGIA.Find(id);
            db.NVD_TACGIA.Remove(nVD_TACGIA);
            db.SaveChanges();
            return RedirectToAction("NvdIndex");
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
