
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
    public class StudioModelsController : Controller
    {
        private FilmyContext db = new FilmyContext();

        public ActionResult Index()
        {
           
            return View(db.Studio.OrderBy(a => a.Nazwa).ToList());
        }
       

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create([Bind(Include = "Nazwa,Logo")] StudioModels ownerModel)
        {
            if (ModelState.IsValid)
            {
                db.Studio.Add(ownerModel);
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

            StudioModels ownerModel = db.Studio.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nazwa,Logo")] StudioModels ownerModelUpdated)
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

            StudioModels ownerModel = db.Studio.Find(id);

            if (ownerModel == null)
            {
                return HttpNotFound();
            }
            return View(ownerModel);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {

            StudioModels ownerModel = db.Studio.Find(id);

            db.Studio.Remove(ownerModel);
          
            db.SaveChanges();                       //zapis zmian
            return RedirectToAction("Index");
        }

        public ActionResult Filmy(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index2", "FilmyModels");
            }
            return RedirectToAction("Index2", "FilmyModels", new { Id = id });
        }

       
    }
}