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

            public string Username { get; set; }
            public string Password { get; set; }
            public string Firstname { get; set; }
            public string Lastname { get; set; }
            public string Address { get; set; }
            public string State { get; set; }
            public string City { get; set; }
            public int Zip { get; set; }
            public int PhoneNo { get; set; }

            public Customer()
            {

            }

        }
    }


