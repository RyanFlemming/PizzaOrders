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
            // Prevent null reference exception
            Pizzas = new List<Pizza>();
        }

        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public List<Pizza> Pizzas { get; set; }
        public int Quantity { get; set; }
    }
}