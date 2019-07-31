using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Toppping
    {
        [Key]
        public int id { get; set; }
        public string ToppingName { get; set; }
        public double ToppingPrice { get; set; }
    }
}
