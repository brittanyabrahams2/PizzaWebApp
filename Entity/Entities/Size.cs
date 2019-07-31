using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Size
    {
        [Key]
        public int id { get; set; }
        public string SizeName { get; set; }
        public double Price { get; set; }
    }
}
