using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SozlesmeKayitIslemleri.Models;

namespace SozlesmeKayitIslemleri.Controllers
{
    public class SozlesmesController : Controller
    {
        private SozlesmeDBContext db = new SozlesmeDBContext();

        // GET: Sozlesmes
        public ActionResult Index()
        {
            return View(db.Sozlesme.ToList());
        }

        // GET: Sozlesmes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sozlesme sozlesme = db.Sozlesme.Find(id);
            if (sozlesme == null)
            {
                return HttpNotFound();
            }
            return View(sozlesme);
        }

        // GET: Sozlesmes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sozlesmes/Create
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SicilNumarasi,TCVergiKimlikNo,UnvanAdSoyad,BaslangicTarihi,BitisTarihi,Durumu,SozlesmeTuru,Aciklama,TalepNumarasi,GelenEvrakTarihi,GelenEvrakSayisi,OlurTarihi,OlurSayisi,Dosya")] Sozlesme sozlesme)
        {
            if (ModelState.IsValid)
            {
                db.Sozlesme.Add(sozlesme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sozlesme);
        }

        // GET: Sozlesmes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sozlesme sozlesme = db.Sozlesme.Find(id);
            if (sozlesme == null)
            {
                return HttpNotFound();
            }
            return View(sozlesme);
        }

        // POST: Sozlesmes/Edit/5
        // Aşırı gönderim saldırılarından korunmak için bağlamak istediğiniz belirli özellikleri etkinleştirin. 
        // Daha fazla bilgi için bkz. https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SicilNumarasi,TCVergiKimlikNo,UnvanAdSoyad,BaslangicTarihi,BitisTarihi,Durumu,SozlesmeTuru,Aciklama,TalepNumarasi,GelenEvrakTarihi,GelenEvrakSayisi,OlurTarihi,OlurSayisi,Dosya")] Sozlesme sozlesme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sozlesme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sozlesme);
        }

        // GET: Sozlesmes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sozlesme sozlesme = db.Sozlesme.Find(id);
            if (sozlesme == null)
            {
                return HttpNotFound();
            }
            return View(sozlesme);
        }

        // POST: Sozlesmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Sozlesme sozlesme = db.Sozlesme.Find(id);
            db.Sozlesme.Remove(sozlesme);
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
