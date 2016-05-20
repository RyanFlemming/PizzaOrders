using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzaOrders.Models
{
    public class Buyer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}