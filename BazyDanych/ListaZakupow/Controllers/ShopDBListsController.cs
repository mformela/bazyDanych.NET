using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ListaZakupow.Models;

namespace ListaZakupow.Controllers
{
    public class ShopDBListsController : Controller
    {
        private Models.AppContext db = new Models.AppContext();

        // GET: ShopDBLists
        public ActionResult Index()
        {
            return View(db.TestDbmodels.ToList());
        }

        // GET: ShopDBLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopDBList shopDBList = db.TestDbmodels.Find(id);
            if (shopDBList == null)
            {
                return HttpNotFound();
            }
            return View(shopDBList);
        }

        // GET: ShopDBLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShopDBLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ShopDBList shopDBList)
        {
            if (ModelState.IsValid)
            {
                var dataTime = DateTime.Now;
                shopDBList.data = dataTime;

                DateTime dataModyf = DateTime.Now;
                shopDBList.dataModyfikacji = dataModyf;

                DateTime dataDodania = DateTime.Now;// tutaj wpisujemy datę dodania 
                shopDBList.data = dataDodania;


                db.TestDbmodels.Add(shopDBList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shopDBList);
        }

        // GET: ShopDBLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopDBList shopDBList = db.TestDbmodels.Find(id);
            if (shopDBList == null)
            {
                return HttpNotFound();
            }

           

            return View(shopDBList);
        }

        // POST: ShopDBLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ShopDBList shopDBList)
        {
            if (ModelState.IsValid)
            {
               

                DateTime dataModyf = DateTime.Now;
                shopDBList.dataModyfikacji = dataModyf;

                db.Entry(shopDBList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shopDBList);
        }

        // GET: ShopDBLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShopDBList shopDBList = db.TestDbmodels.Find(id);
            if (shopDBList == null)
            {
                return HttpNotFound();
            }
            return View(shopDBList);
        }

        // POST: ShopDBLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShopDBList shopDBList = db.TestDbmodels.Find(id);
            db.TestDbmodels.Remove(shopDBList);
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
