using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmy.DAL;
using Filmy.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;

namespace Filmy.Controllers
{
    public class WypozyczeniaModelsController : Controller
    {
        private FilmyContext db = new FilmyContext();

        public ActionResult Index(int filmID)
        {
          
            WypozyczeniaModels wypozycz = new WypozyczeniaModels(); 

            var username = User.Identity.GetUserName();
            int userId = (from x in db.Uzytkownik where x.Nazwa == username select x.ID ).SingleOrDefault(); 
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            string tytul =(from x in db.Film where x.ID == filmID select x.Tytul).SingleOrDefault();

            wypozycz.FilmID = filmID;
            wypozycz.Film_Tytul= tytul;

            wypozycz.UzytkownicyID = userId;
            wypozycz.Data = date;

            db.Wypozyczenia.Add(wypozycz);
            db.SaveChanges();

            return RedirectToAction("Moje_filmy");
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Moje_filmy");
            }

            WypozyczeniaModels ownerModel = db.Wypozyczenia.Find(id);

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
        public ActionResult Create([Bind(Include = "FilmID, UzytkownicyID")] WypozyczeniaModels ownerModel)
        {
            if (ModelState.IsValid)
            {
                db.Wypozyczenia.Add(ownerModel);
                db.SaveChanges();                       //zapis zmian
                return RedirectToAction("Moje_filmy");
            }
            return View(ownerModel);       //zostaną dane w formularzu 
        }


        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Moje_filmy");
            }

            WypozyczeniaModels ownerModel = db.Wypozyczenia.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilmID, UzytkownicyID")] WypozyczeniaModels ownerModelUpdated)
        {

            if (ModelState.IsValid)
            {
                db.Entry(ownerModelUpdated).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Moje_filmy");
            }
            return View(ownerModelUpdated);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Moje_filmy");
            }

            WypozyczeniaModels ownerModel = db.Wypozyczenia.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
           
            WypozyczeniaModels ownerModel = db.Wypozyczenia.Find(id);

            db.Wypozyczenia.Remove(ownerModel);
            db.SaveChanges();                       //zapis zmian
            return RedirectToAction("Moje_filmy");
        }

        public ActionResult Filmy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "FilmyModels");
            }
            return RedirectToAction("Index", "FilmyModels", new { Id = id });
        }
        public ActionResult Moje_filmy()
        {
             var username = User.Identity.GetUserName();
             int userId = (from x in db.Uzytkownik where x.Nazwa == username select x.ID).SingleOrDefault();

            if (User.IsInRole("user"))
            {
                var hist = db.Wypozyczenia.Where(y => y.UzytkownicyID == userId).ToList();
                return View(hist);
            }
            else if (User.IsInRole("admin"))
            {
                return View(db.Wypozyczenia.ToList());
            }

            return View();
        }

        public ActionResult Powrot()
        {
          
            return RedirectToAction("Index", "Manage", new { });

        }
    }
}