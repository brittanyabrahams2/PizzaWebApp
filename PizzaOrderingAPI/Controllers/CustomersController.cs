using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaOrderingAPI.Models;
using Microsoft.AspNetCore.Cors;
using Entities;
using ApplicationDbContext = PizzaOrderingAPI.Models.ApplicationDbContext;

namespace PizzaOrderingAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class CustomersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Customers

        public IEnumerable<Customer> GetCustomer()
        {
            return _context.Customer;
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
       

        public async Task<IActionResult> GetCustomer([FromRoute] int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = await _context.Customer.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }






        [HttpGet("{Username},{Password}")]
        public IActionResult Login([FromRoute] string Username, string Password)
        {
            // check if username and password
            var customer = _context.Customer
         .Where(x => x.Username == Username && x.Password == Password).FirstOrDefault();
           

            if (customer != null)
            {
               
                return Ok(customer);

            }
            else
            {
             
                return NotFound();
            }

        }
       

        // PUT: api/Customers/5
        [HttpPut("{id}")]
       
        public async Task<IActionResult> Edit([FromRoute] int id, [FromBody] Customer customer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            _context.Entry(customer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
               
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        //POST: api/Customers
       [HttpPost]
        public async Task<IActionResult> Register([FromBody] Customer customer)
        {

           
             if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (_context.Customer.Any(x => x.Username == customer.Username))
            {
                return Content("Failed, username already existed");
            }
            else
            {
                _context.Customer.Add(customer);
               await _context.SaveChangesAsync();

            return CreatedAtAction("GetCustomer", new { id = customer.CustomerId }, customer);
              
            }

           
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();

            return Ok(customer);
        }



        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }

    }
}