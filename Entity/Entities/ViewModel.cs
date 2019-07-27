using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class ViewModel
    {
        public IEnumerable<Size> sizes{ get; set; }
        public IEnumerable<Sauce> sauces { get; set; }
        public IEnumerable<Crust> crusts { get; set; }
        public IEnumerable<SauceAmount> sauceAmounts { get; set; }
        public IEnumerable<Toppping> toppings { get; set; }
        public IEnumerable<CheeseAmount> cheeseAmounts { get; set; }
 

    }
}
