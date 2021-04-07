using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmy.DAL;
using System.Linq;
using Filmy.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Filmy.Controllers
{
    public class FilmyModelsController : Controller
       
    {
        private FilmyContext db = new FilmyContext();
      
        public ActionResult Index(int ? id)
        {
            
          if(id==null)
            {
                return View(db.Film.OrderBy(a => a.Tytul).ToList());
            }
             var ViewModel = db.Film.Include(g=>g.Gatunek).Where(x => x.GatunekID == id).OrderBy(a => a.Tytul).ToList();

               return View(ViewModel);

       }
      
        public ActionResult Index2(int? id)
        {
            if (id == null)
            {
                return View(db.Film.OrderBy(a => a.Tytul).ToList());
            }

            var ViewModel = db.Film.Include(g => g.Studio).Where(x => x.StudioID == id).OrderBy(a => a.Tytul).ToList();
            return View(ViewModel);

        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            FilmyModels ownerModel = db.Film.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }

            return View(ownerModel);
        }

        public ActionResult Create()
        {
            ViewBag.GatunekID = new SelectList(db.Gatunek, "ID", "Nazwa");
            ViewBag.StudioID = new SelectList(db.Studio, "ID", "Nazwa");

            return View();
        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "Tytul,Dlugosc,Plakat,Opis,GatunekID,StudioID")] FilmyModels ownerModel)
        {
          
            if (ModelState.IsValid)
            {
                db.Film.Add(ownerModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GatunekID = new SelectList(db.Gatunek, "ID", "Nazwa", ownerModel.GatunekID);
            ViewBag.StudioID = new SelectList(db.Studio, "ID", "Nazwa", ownerModel.StudioID);

            return View(ownerModel);

        }


        public ActionResult Edit(int? id)
        {

            ViewBag.GatunekID = new SelectList(db.Gatunek, "ID", "Nazwa");
            ViewBag.StudioID = new SelectList(db.Studio, "ID", "Nazwa");
            if (id == null)
            {
                return RedirectToAction("Index");
            }
             FilmyModels ownerModel = db.Film.Find(id);
            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
      
        public ActionResult Edit([Bind(Include = "ID,Tytul,Dlugosc,Plakat,Opis,GatunekID,StudioID")] FilmyModels ownerModelUpdated)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ownerModelUpdated).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GatunekID = new SelectList(db.Gatunek, "ID", "Nazwa", ownerModelUpdated.GatunekID);
            ViewBag.StudioID = new SelectList(db.Studio, "ID", "Nazwa", ownerModelUpdated.StudioID);

            return View(ownerModelUpdated);
           
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            FilmyModels ownerModel = db.Film.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            FilmyModels ownerModel = db.Film.Find(id);

            db.Film.Remove(ownerModel);
            db.SaveChanges();                       //zapis zmian
            return RedirectToAction("Index");
        }

        public ActionResult Rental(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index2", "FilmyModels");
            }
            return RedirectToAction("Index", "WypozyczeniaModels", new { filmID = id });
        }
    }
}