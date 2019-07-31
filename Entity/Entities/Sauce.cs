using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Sauce
    {
       [Key]
       public int id { get; set; }
       public string SauceName { get; set; }
       public double Price { get; set; }
    }
}
