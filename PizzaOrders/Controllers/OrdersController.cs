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
        public ActionResult Create()
        {
            return View();
        }


        // TO DO
        [HttpPost]
        public ActionResult Create(Order order)
        {
            return View();
        }

	}
}