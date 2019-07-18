using System;
using System.Collections.Generic;


namespace Entities
{
    public interface IPizza
    {
        //properties

        int PizzaId { get; set; }
        Size Size { get; set; }
        Sauce Sauce { get; set; }
        SauceAmount SauceAmount { get; set; }
        CheeseAmount CheeseAmount { get; set; }
        Crust Crust { get; set; }

        Order Order { get; set; }


        int ToppingCount { get; set; }
        double Price { get; set; }

        int Topping1 { get; set; }
        int Topping2 { get; set; }
        int Topping3 { get; set; }
        int Topping4 { get; set; }
        int Topping5 { get; set; }


    
        List<Toppping> ToppingList { get; set; }


        //methods
   


       



    }
}
