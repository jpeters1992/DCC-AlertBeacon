using ALERTBEACON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALERTBEACON.Controllers
{
    public class ObserverController : Controller
    {
        ApplicationDbContext db;
        // GET: Observer
        public ObserverController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<Observer> observers = db.Observers.ToList();
            return View(observers);
        }
        // GET: Observer/Details/5
        public ActionResult Details(int id)
        {
            Observer observer = db.Observers.Where(c => c.Id == id).FirstOrDefault();
            return View(observer);
        }
        // GET: Observer/Create
        public ActionResult Create()
        {
            Observer observer = new Observer();
            return View(observer);
        }
        // POST: Observer/Create
        [HttpPost]
        public ActionResult Create(Observer observer)
        {
            try
            {
                // TODO: Add insert logic here
                db.Observers.Add(observer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Observer/Edit/5
        public ActionResult Edit(int id)
        {
            Observer observer = db.Observers.Where(c => c.Id == id).FirstOrDefault();
            return View(observer);
        }
        // POST: Observer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Observer observer)
        {
            try
            {
                // TODO: Add update logic here
                Observer dbobserver = db.Observers.Where(c => c.Id == id).FirstOrDefault();
                dbobserver.LicensePlate = observer.LicensePlate;
                dbobserver.Email = observer.Email;
                dbobserver.PhoneNumber = observer.PhoneNumber;
                dbobserver.Reward = observer.Reward;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Observer/Delete/5
        public ActionResult Delete(int id)
        {
            Observer observer = db.Observers.Where(c => c.Id == id).FirstOrDefault();
            return View(observer);
        }
        // POST: Observer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Observer observer)
        {
            try
            {
                observer = db.Observers.Where(c => c.Id == id).FirstOrDefault();
                db.Observers.Remove(observer);
                db.SaveChanges();
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
