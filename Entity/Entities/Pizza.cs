
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Pizza: IPizza
    {
        //Pizza constructor
        public Pizza()
        {
            ToppingList = new List<Toppping>();

        }

        //public properties
        [Key]
        public int PizzaId { get; set; }
        public Size Size { get; set; }
        public Sauce Sauce { get; set; }
        public SauceAmount SauceAmount { get; set; }
        public CheeseAmount CheeseAmount { get; set; }
        public Crust Crust { get; set; }

        public Order Order { get; set; }


        public int ToppingCount { get; set; }
        public double Price { get; set; }

        public int? Topping1 { get; set; }
        public int? Topping2 { get; set; }
        public int? Topping3 { get; set; }
        public int? Topping4 { get; set; }
        public int? Topping5 { get; set; }


        [NotMapped]
        public List<Toppping> ToppingList { get; set; }

        [NotMapped]
        public List<Pizza> Pizzas { get; set; }

      

        //public methods

  




    }
}
