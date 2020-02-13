using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCProjectMain2.Models;

namespace MVCProjectMain2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Registrations.ToList());
            }
                
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Registrations.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Registration customer)
        {
            try
            {

                // TODO: Add insert logic here
                using (DBModels db = new DBModels())
                {
                    db.Registrations.Add(customer);
                    db.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Registrations.Where(x => x.Id == id).FirstOrDefault());
            }
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Registration customer)
        {
            try
            {
                // TODO: Add update logic here
                using (DBModels db = new DBModels())
                {
                    db.Entry(customer).State = EntityState.Modified;
                    db.SaveChanges();
                }
                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            using (DBModels db = new DBModels())
            {
                return View(db.Registrations.Where(x=> x.Id == id).FirstOrDefault());
            }
                
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Registration customer)
        {
            try
            {
                // TODO: Add delete logic here
                using (DBModels db = new DBModels())
                {
                    customer = db.Registrations.Where(x => x.Id == id).FirstOrDefault();
                    db.Registrations.Remove(customer);
                    db.SaveChanges();
                }

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
