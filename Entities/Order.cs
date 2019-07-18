using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public Customer customer { get; set; }
        public double Price { get; set; }
        public bool IsDelivered { get; set; }
        public DateTime OrderDate { get; set; }
        



    }
}
