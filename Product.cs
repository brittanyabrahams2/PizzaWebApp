using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Product
    {
        [Key]
        public int productCode { get; set; }
        public string productDescription { get; set; }
       
        public string productName { get; set; }
    }
}
