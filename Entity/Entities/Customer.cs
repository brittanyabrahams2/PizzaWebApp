using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities
{
    public class Customer
    {
            [Key]
            public int CustomerId { get; set; }

            [Required]
            public string Username { get; set; }
            [Required]
            public string Password { get; set; }

            [Required]
            public string Firstname { get; set; }
            [Required]
            public string Lastname { get; set; }
            [Required]
            public string Address { get; set; }
            [Required]

            public string State { get; set; }
            [Required]
            public string City { get; set; }
            [Required]
            public string Zip { get; set; }
            [Required]
            public string PhoneNo { get; set; }

            public Customer()
            {

            }

        }
    }


