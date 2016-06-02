using PizzaOrders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzaOrders.Controllers
{
    public class OrdersController : Controller
    {
        private PizzaOrdersDbContext db = new PizzaOrdersDbContext();
        /*
         * Implement Identity first
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
         */


        [HttpGet]
        public ActionResult Create(int id)
        {
            Order order = new Order();
            order.BuyerId = id;
            return View(order);
        }


        [HttpPost]
        public ActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
            return View(order);
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