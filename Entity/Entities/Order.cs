using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Order
    {
    
        public int OrderId { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
      
        public double Price { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime OrderDate { get; set; }
        
        //public methods
        static public int GenerateOrderId()
        {
            //uint range: 4.294967295 × 10^9
            //int range: -2.147483648 x 10^9 to 2.147483647 x 10^9
           //problem: repeated id
           

            int intMax = int.MaxValue;

            Random random = new Random();
            int randomint = random.Next(1, intMax);

            return randomint;
        }


    }
}
