namespace PizzaOrders.Migrations
{
    using PizzaOrders.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PizzaOrders.Models.PizzaOrdersDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PizzaOrders.Models.PizzaOrdersDbContext context)
        {
            context.Restaurants.AddOrUpdate(
            p => p.Id,
            new Restaurant { Name = "LaRosas" },
            new Restaurant { Name = "Gigi" }
            );
    
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
