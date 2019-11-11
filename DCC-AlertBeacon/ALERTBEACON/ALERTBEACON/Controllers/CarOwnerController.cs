using ALERTBEACON.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALERTBEACON.Controllers
{
    public class CarOwnerController : Controller
    {
        ApplicationDbContext db;
        // GET: CarOwner
        public CarOwnerController()
        {
            db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            List<CarOwner> carOwners = db.CarOwners.ToList();
            return View(carOwners);
        }
        // GET: CarOwner/Details/5
        public ActionResult Details(int id)
        {
            CarOwner carOwner = db.CarOwners.Where(c => c.Id == id).FirstOrDefault();
            return View(carOwner);
        }
        // GET: CarOwner/Create
        public ActionResult Create()
        {
            CarOwner carOwner = new CarOwner();
            return View(carOwner);
        }
        // POST: CarOwner/Create
        [HttpPost]
        public ActionResult Create(CarOwner carOwner)
        {
            try
            {
                // TODO: Add insert logic here
                db.CarOwners.Add(carOwner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: CarOwner/Edit/5
        public ActionResult Edit(int id)
        {
            CarOwner carOwner = db.CarOwners.Where(c => c.Id == id).FirstOrDefault();
            return View(carOwner);
        }
        // POST: CarOwner/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CarOwner carOwner)
        {
            try
            {
                // TODO: Add update logic here
                CarOwner dbcarowner = db.CarOwners.Where(c => c.Id == id).FirstOrDefault();
                dbcarowner.LicensePlate = carOwner.LicensePlate;
                dbcarowner.FirstName = carOwner.FirstName;
                dbcarowner.LastName = carOwner.LastName;
                dbcarowner.StreetAddress = carOwner.StreetAddress;
                dbcarowner.City = carOwner.City;
                dbcarowner.State = carOwner.State;
                dbcarowner.Reward = carOwner.Reward;
                dbcarowner.Email = carOwner.Email;
                dbcarowner.PhoneNumber = carOwner.PhoneNumber;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: CarOwner/Delete/5
        public ActionResult Delete(int id)
        {
            CarOwner carOwner = db.CarOwners.Where(c => c.Id == id).FirstOrDefault();
            return View(carOwner);
        }
        // POST: CarOwner/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, CarOwner carOwner)
        {
            try
            {
                // TODO: Add delete logic here
                carOwner = db.CarOwners.Where(c => c.Id == id).FirstOrDefault();
                db.CarOwners.Remove(carOwner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View(id);
            }
        }
    }
}
