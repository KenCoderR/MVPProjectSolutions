using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVPProjectOne.Models;

namespace MVPProjectOne.Controllers.ProjectOne
{
    public class ProductSoldsController : Controller
    {
        private MVPProjectOneContext db = new MVPProjectOneContext();

        // GET: ProductSolds
        public ActionResult Index()
        {
            return View(db.ProductSolds.ToList());
        }

        // GET: ProductSolds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductSold productSold = db.ProductSolds.Find(id);
            if (productSold == null)
            {
                return HttpNotFound();
            }
            return View(productSold);
        }

        // GET: ProductSolds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductSolds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ProductId,ConsumerId,StoreId,DataSold,Customer_Id,Store_Id,Product_Id")] ProductSold productSold)
        {
            if (ModelState.IsValid)
            {
                db.ProductSolds.Add(productSold);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productSold);
        }

        // GET: ProductSolds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductSold productSold = db.ProductSolds.Find(id);
            if (productSold == null)
            {
                return HttpNotFound();
            }
            return View(productSold);
        }

        // POST: ProductSolds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ProductId,ConsumerId,StoreId,DataSold,Customer_Id,Store_Id,Product_Id")] ProductSold productSold)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productSold).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(productSold);
        }

        // GET: ProductSolds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductSold productSold = db.ProductSolds.Find(id);
            if (productSold == null)
            {
                return HttpNotFound();
            }
            return View(productSold);
        }

        // POST: ProductSolds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductSold productSold = db.ProductSolds.Find(id);
            db.ProductSolds.Remove(productSold);
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
