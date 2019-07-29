﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entity;
using pizza_API_;
using Microsoft.AspNetCore.Cors;

namespace pizza_API_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class PizzasController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PizzasController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/Pizza
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value123144", "value21231231" };
        //}


        // GET: api/Pizzas (in shopping cart)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pizza>>> GetPizzas()
        {
            return await _context.Pizzas.Where(p=>p.Order.Ischeckout==false).ToListAsync();
        }


        // GET: api/Pizzas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pizza>> GetPizza(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);

            if (pizza == null)
            {
                return NotFound(); 
            }

            return pizza;
        }

        // PUT: api/Pizzas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizza(int id, Pizza pizza)
        {
            if (id != pizza.PizzaId)
            {
                return BadRequest();
            }

            _context.Entry(pizza).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PizzaExists(id))
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

        // POST: api/Pizzas
        [HttpPost]
        public async Task<ActionResult<Pizza>> PostPizza(Pizza pizza)
        {
            //get  oderId from cust 
            // else new order 


            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Order existingOrder = _context.Orders.Where(o => o.Ischeckout == false).FirstOrDefault();
            if (existingOrder == null)
            {
                var order = new Order
                {
                    OrderDate = DateTime.Now,
                    Ischeckout = false,
                    UserId = 1
                };
                pizza.OrderId = order.OrderId;
                _context.Orders.Add(order);
                _context.Pizzas.Add(pizza);
            }
            else
            {
                pizza.OrderId = existingOrder.OrderId;
                _context.Pizzas.Add(pizza);
            }


            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPizza", new { id = pizza.PizzaId }, pizza);
        }

        // DELETE: api/Pizzas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pizza>> DeletePizza(int id)
        {
            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }

            _context.Pizzas.Remove(pizza);
            await _context.SaveChangesAsync();

            return pizza;
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizzas.Any(e => e.PizzaId == id);
        }
    }
}