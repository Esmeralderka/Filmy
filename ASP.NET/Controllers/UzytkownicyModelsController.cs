using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmy.DAL;
using Filmy.Models;
using System.Data.Entity;
namespace Filmy.Controllers

{
    public class UzytkownicyModelsController : Controller
    {
        private FilmyContext db = new FilmyContext();

        public ActionResult Index()
        {
            return View(db.Uzytkownik.ToList());
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            UzytkownicyModels ownerModel = db.Uzytkownik.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }

            return View(ownerModel);
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "Nazwa,Data_dolaczenia")] UzytkownicyModels ownerModel)
        {
            if (ModelState.IsValid)
            {
                db.Uzytkownik.Add(ownerModel);
                db.SaveChanges();                       //zapis zmian
                return RedirectToAction("Index");
            }
            return View(ownerModel);       //zostaną dane w formularzu 
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            UzytkownicyModels ownerModel = db.Uzytkownik.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nazwa,Data_dolaczenia")] UzytkownicyModels ownerModelUpdated)
        {

            if (ModelState.IsValid)
            {
                db.Entry(ownerModelUpdated).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ownerModelUpdated);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            UzytkownicyModels ownerModel = db.Uzytkownik.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            UzytkownicyModels ownerModel = db.Uzytkownik.Find(id);
            db.Uzytkownik.Remove(ownerModel);
            db.SaveChanges();                       //zapis zmian
            return RedirectToAction("Index");
        }

        public ActionResult Filmy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "FilmyModels");
            }
            return RedirectToAction("Index", "FilmyModels", new { Id = id });
        }

    }
}