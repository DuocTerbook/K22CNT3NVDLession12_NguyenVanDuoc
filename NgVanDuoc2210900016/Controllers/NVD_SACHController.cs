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
    public class NVD_SACHController : Controller
    {
        private NgVanDuoc_2210900016Entities db = new NgVanDuoc_2210900016Entities();

        // GET: NVD_SACH
        public ActionResult NvdIndex()
        {
            var nVD_SACH = db.NVD_SACH.Include(n => n.NVD_TACGIA);
            return View(nVD_SACH.ToList());
        }

        // GET: NVD_SACH/Details/5
        public ActionResult NvdDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVD_SACH nVD_SACH = db.NVD_SACH.Find(id);
            if (nVD_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nVD_SACH);
        }

        // GET: NVD_SACH/Create
        public ActionResult NvdCreate()
        {
            ViewBag.Nvd_MaTG = new SelectList(db.NVD_TACGIA, "Nvd_MaTG", "Nvd_TenTacGia");
            return View();
        }

        // POST: NVD_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvdCreate([Bind(Include = "Nvd_MaSach,Nvd_TenSach,Nvd_SoTrang,Nvd_NamXB,Nvd_MaTG,Nvd_TrangThai")] NVD_SACH nVD_SACH)
        {
            if (ModelState.IsValid)
            {
                db.NVD_SACH.Add(nVD_SACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Nvd_MaTG = new SelectList(db.NVD_TACGIA, "Nvd_MaTG", "Nvd_TenTacGia", nVD_SACH.Nvd_MaTG);
            return View(nVD_SACH);
        }

        // GET: NVD_SACH/Edit/5
        public ActionResult NvdEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVD_SACH nVD_SACH = db.NVD_SACH.Find(id);
            if (nVD_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.Nvd_MaTG = new SelectList(db.NVD_TACGIA, "Nvd_MaTG", "Nvd_TenTacGia", nVD_SACH.Nvd_MaTG);
            return View(nVD_SACH);
        }

        // POST: NVD_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvdEdit([Bind(Include = "Nvd_MaSach,Nvd_TenSach,Nvd_SoTrang,Nvd_NamXB,Nvd_MaTG,Nvd_TrangThai")] NVD_SACH nVD_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nVD_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("NvdIndex");
            }
            ViewBag.Nvd_MaTG = new SelectList(db.NVD_TACGIA, "Nvd_MaTG", "Nvd_TenTacGia", nVD_SACH.Nvd_MaTG);
            return View(nVD_SACH);
        }

        // GET: NVD_SACH/Delete/5
        public ActionResult NvdDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NVD_SACH nVD_SACH = db.NVD_SACH.Find(id);
            if (nVD_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nVD_SACH);
        }

        // POST: NVD_SACH/Delete/5
        [HttpPost, ActionName("NvdDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NVD_SACH nVD_SACH = db.NVD_SACH.Find(id);
            db.NVD_SACH.Remove(nVD_SACH);
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
