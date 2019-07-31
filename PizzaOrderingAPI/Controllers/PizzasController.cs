using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities;
using PizzaOrderingAPI.Models;
using Microsoft.AspNetCore.Cors;


namespace PizzaOrderingAPI.Controllers
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

        [HttpGet]
        public IEnumerable<Pizza> GetPizzas()
        {
            return _context.Pizza;
        }

        // GET: api/Pizzas
        [HttpGet]
        [Route("GetPizzaInfo")]
        public IActionResult GetPizzaInfo()
        {
            var viewmodel = new ViewModel();
            viewmodel.sizes = _context.Size.ToList();
            viewmodel.toppings = _context.Topping.ToList();
            viewmodel.crusts = _context.Crust.ToList();
            viewmodel.sauces = _context.Sauce.ToList();
            viewmodel.sauceAmounts = _context.SauceAmount.ToList();
            viewmodel.cheeseAmounts = _context.CheeseAmount.ToList();

            return Ok(viewmodel);
        }

        // GET: api/Pizzas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPizza([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pizza = await _context.Pizza.FindAsync(id);

            if (pizza == null)
            {
                return NotFound();
            }

            return Ok(pizza);
        }

        // PUT: api/Pizzas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPizza([FromRoute] int id, [FromBody] Pizza pizza)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

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
        public async Task<IActionResult> CreatePizza([FromBody]  Pizza pizza)
        {
           
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            switch (pizza.ToppinIdList.Count())
            {
                case 1:
                    pizza.Topping1 = pizza.ToppinIdList[0];
                    break;
                case 2:
                    pizza.Topping1 = pizza.ToppinIdList[0];
                    pizza.Topping2 = pizza.ToppinIdList[1];
                    break;
                case 3:
                    pizza.Topping1 = pizza.ToppinIdList[0];
                    pizza.Topping2 = pizza.ToppinIdList[1];
                    pizza.Topping3 = pizza.ToppinIdList[2];
                    break;
                case 4:
                    pizza.Topping1 = pizza.ToppinIdList[0];
                    pizza.Topping2 = pizza.ToppinIdList[1];
                    pizza.Topping3 = pizza.ToppinIdList[2];
                    pizza.Topping4 = pizza.ToppinIdList[3];
                    break;
                case 5:
                    pizza.Topping1 = pizza.ToppinIdList[0];
                    pizza.Topping2 = pizza.ToppinIdList[1];
                    pizza.Topping3 = pizza.ToppinIdList[2];
                    pizza.Topping4 = pizza.ToppinIdList[3];
                    pizza.Topping5 = pizza.ToppinIdList[4];
                    break;
                default:
                    //error, can not allow more than 5 toppings
                    break;

            }//end swtich

            PizzaPriceModel priceModel = new PizzaPriceModel(); 

            //get price from database
            priceModel.SizePrice = Convert.ToDouble(_context.Size.Find(pizza.SizeId).Price);
            priceModel.CrustPrice = Convert.ToDouble(_context.Crust.Find(pizza.CrustId).Price);
            priceModel.SaucePrice = Convert.ToDouble(_context.Sauce.Find(pizza.SauceId).Price);
            priceModel.SauceAmountPrice = Convert.ToDouble(_context.SauceAmount.Find(pizza.SauceAmountId).Price);
            priceModel.CheeseAmountPrice = Convert.ToDouble(_context.CheeseAmount.Find(pizza.CheeseAmountId).Price);
            foreach (var itemId in pizza.ToppinIdList)//get all toppings price
            {
                priceModel.ToppingPrice += Convert.ToDouble(_context.Topping.Find(itemId).ToppingPrice);

            }
        

            pizza.Price = pizza.getTotalPrice(priceModel); // calculate total price




            var modifyOrder = _context.Order.Find(pizza.OrderId);
            modifyOrder.Price = pizza.Price;
            

            _context.Pizza.Add(pizza);
            _context.Entry(modifyOrder).State = EntityState.Modified;

            //_context.Order.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPizza", new { id = pizza.PizzaId }, pizza);
        }

        // DELETE: api/Pizzas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePizza([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var pizza = await _context.Pizza.FindAsync(id);
            if (pizza == null)
            {
                return NotFound();
            }

            _context.Pizza.Remove(pizza);
            await _context.SaveChangesAsync();

            return Ok(pizza);
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizza.Any(e => e.PizzaId == id);
        }
    }
}