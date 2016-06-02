using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PizzaOrders.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Display(Name="Restaurant Name")]
        public Name PlaceOfOrder { get; set; }

        public enum Name
        {
            LaRosas,
            Gigi
        }
    }
}