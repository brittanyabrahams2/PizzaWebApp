using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Payment
    {
        public Customer customer { get; set; }
        public string CardNo{ get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
        
       



    }
}
