using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Entity;
using pizzaUI.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;

namespace pizzaUI.Controllers
{
    public class PizzasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private string _url = "http://localhost:60519/";
        HttpClient client = new HttpClient();


        //public PizzasController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}

        // GET: Pizzas
        public async Task<IActionResult> Index()
        {
            IEnumerable<Pizza> pizzas = null;
            using (var client = new HttpClient())
            {
                var apiUrl = "api/pizzas";
                client.BaseAddress = new Uri(_url + apiUrl);
                //HTTP GET
                // PizzaAPI.Controllers.CustomerController c = new PizzaAPI.Controllers.CustomerController(_context);
                var responseTask = client.GetAsync("pizzas");
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<Pizza>>();
                    readTask.Wait();
                    pizzas = readTask.Result;
                }
                else //web api sent error response
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(pizzas);




        }

        // GET: Pizzas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Pizza pizza = null;
            using (var client = new HttpClient())
            {
                var apiUrl = "api/pizzas";
                client.BaseAddress = new Uri(_url + apiUrl);
                //HTTP GET
                // PizzaAPI.Controllers.CustomerController c = new PizzaAPI.Controllers.CustomerController(_context);
                var responseTask = client.GetAsync("pizzas/"+id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Pizza>();
                    readTask.Wait();
                    pizza = readTask.Result;
                }
                else //web api sent error response
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(pizza);
        }

        // GET: Pizzas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pizzas/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PizzaId,Price,Size,ToppingId1,ToppingId2,ToppingId3,ToppingId4,ToppingId5")] Pizza pizza)
        {
            using (var client = new HttpClient())
            {
                var apiUrl = "api/pizzas";
                client.BaseAddress = new Uri(_url+apiUrl);
                //HTTP GET
                // PizzaAPI.Controllers.CustomerController c = new PizzaAPI.Controllers.CustomerController(_context);
                var postTask = client.PostAsJsonAsync("pizzas", pizza);
                postTask.Wait();
                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
            }
            return View(pizza);
        }

        // GET: Pizzas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id);
        }

        // POST: Pizzas/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PizzaId,Price,Size,ToppingId1,ToppingId2,ToppingId3,ToppingId4,ToppingId5")] Pizza pizza)
        {
            using (var client = new HttpClient())
            {
                var apiUrl = "api/pizzas";
                client.BaseAddress = new Uri(_url + apiUrl);

                //HTTP POST
                var putTask = client.PutAsJsonAsync<Pizza>("pizzas/" + id, pizza);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(pizza);
        }

        // GET: Pizzas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id);

        }

        // POST: Pizzas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            using (var client = new HttpClient())
            {

                //HTTP DELETE
                var apiUrl = "api/pizzas";
                client.BaseAddress = new Uri(_url + apiUrl);

             
                var deleteTask = client.DeleteAsync("pizzas/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return await Delete(id);
        }

        private bool PizzaExists(int id)
        {
            return _context.Pizza.Any(e => e.PizzaId == id);
        }
    }
}
