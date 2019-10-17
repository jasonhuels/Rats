using System.Collections.Generic;

namespace Ratstaurant.Models
{
    public class Review
    {
        public int ID {get; set;}
        public string User {get; set;}
        public int RestaurantID {get; set;}
        public virtual Restaurant Restaurant {get; set;}
        public string Critique {get; set;}
    }
}