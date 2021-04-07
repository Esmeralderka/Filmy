
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmy.DAL;
using Filmy.Models;

namespace Filmy.Controllers
{
    public class GatunekModelsController : Controller
    {
        private FilmyContext db = new FilmyContext();

        public ActionResult Index()
        {
           
            return View(db.Gatunek.OrderBy(a => a.Nazwa).ToList());
        }
       

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "Nazwa")] GatunekModels ownerModel)
        {
            if (ModelState.IsValid)
            {
                db.Gatunek.Add(ownerModel);
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

            GatunekModels ownerModel = db.Gatunek.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nazwa")] GatunekModels ownerModelUpdated)
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

            GatunekModels ownerModel = db.Gatunek.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
         
          GatunekModels ownerModel = db.Gatunek.Find(id);

            db.Gatunek.Remove(ownerModel);
         
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