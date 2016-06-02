using PizzaOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaOrders.Controllers
{
    public class BuyerController : Controller
    {

        private PizzaOrdersDbContext db = new PizzaOrdersDbContext();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                db.Buyers.Add(buyer);
                db.SaveChanges();
                return RedirectToAction("Create", "Orders", new { id=buyer.Id});
            }
            return View(buyer);
        }

        // House cleaning just to be safe
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