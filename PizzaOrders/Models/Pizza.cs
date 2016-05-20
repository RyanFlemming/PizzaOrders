using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOrders.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        [Flags]
        enum Toppings
        {
            None = 0,
            Mushroom = 1,
            Olives = 2,
            Pepperoni = 3

        };

    }
}