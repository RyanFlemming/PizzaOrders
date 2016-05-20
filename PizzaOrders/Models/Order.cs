using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOrders.Models
{
    public class Order
    {
        public Order()
        {
            Pizzas = new List<Pizza>();
        }

        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public List<Pizza> Pizzas { get; set; }
    }
}