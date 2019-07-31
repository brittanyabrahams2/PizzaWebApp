using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class SauceAmount
    {
        [Key]
        public int id { get; set; }
        public string Amount { get; set; }
        public double Price { get; set; }

    }
}
