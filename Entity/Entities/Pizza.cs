
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;

namespace Entities
{
    public class Pizza
    {
        //Pizza constructor
        public Pizza()
        {
            //ToppingList = new List<Toppping>();

        }

        //public properties
        [Key]
        public int PizzaId { get; set; }
        public int SizeId { get; set; }
        public int SauceId { get; set; }
        public int SauceAmountId { get; set; }
        public int CheeseAmountId { get; set; }
        public int CrustId { get; set; }

        public int OrderId { get; set; }


        public int ToppingCount { get; set; }
        public double Price { get; set; }

        public int? Topping1 { get; set; }
        public int? Topping2 { get; set; }
        public int? Topping3 { get; set; }
        public int? Topping4 { get; set; }
        public int? Topping5 { get; set; }


        [NotMapped]
        public int[] ToppinIdList { get; set; }
        [NotMapped]
        public double ToppingPrice { get; set; }

        //[NotMapped]
        //public List<Pizza> Pizzas { get; set; }

      

        //public methods
      


        public double getTotalPrice(PizzaPriceModel priceModel)
        {
            var jsonData = JsonConvert.SerializeObject(priceModel);//convert object to json
            var dictionary = JsonConvert.DeserializeObject<Dictionary<string, double>>(jsonData);// convert json to dictionary
            foreach(var itemPrice in dictionary.Values)//only need values 
            {
                Price += itemPrice;
            }
            return Price;
        }
  




    }
}
