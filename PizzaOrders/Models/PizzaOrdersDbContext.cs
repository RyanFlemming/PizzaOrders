using PizzaOrders.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PizzaOrders.Models
{
    public class PizzaOrdersDbContext : DbContext
    {

        // Using Entity Framework convention to create the connection string
        public PizzaOrdersDbContext()
            : base("PizzaOrdersDb")
        {
        }

        public DbSet<Buyer> Buyers { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}