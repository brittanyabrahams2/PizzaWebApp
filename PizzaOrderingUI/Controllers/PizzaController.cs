using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
using System.Net.Http;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Http;

namespace PizzaOrderingUI.Controllers
{
    public class PizzaController : Controller
    {
        private string _url = "http://localhost:54241/";
        public async Task<IActionResult> CreatePizzaIndex()
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
            var s = HttpContext.Session.GetInt32("OrderId");
            //return View(pizzas.Where(id => id.OrderId == HttpContext.Session.GetInt32("OrderId")));
            return View(pizzas);
        }



        public ActionResult ConfirmationView()
        {
            if (HttpContext.Session.GetString("CustomerId") != null)
            {
                return View();
            }
            return Content("Please login");
        }

        // GET: Pizza
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult GetPizzaInfo()
        {
            if (HttpContext.Session.GetString("CustomerId") != null)
            {
                return View();
            }
            return RedirectToAction("Login","Customer");
        }


        // GET: Pizza/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            Pizza pizza = null;
            using (var client = new HttpClient())
            {
                var apiUrl = "api/pizzas";
                client.BaseAddress = new Uri(_url + apiUrl);
                //HTTP GET
                // PizzaAPI.Controllers.CustomerController c = new PizzaAPI.Controllers.CustomerController(_context);
                var responseTask = client.GetAsync("pizzas/" + id);
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

        // GET: Pizza/Create
        public ActionResult CreatePizza()
        {
            if (HttpContext.Session.GetString("CustomerId") != null)
            {
                
                return View();
            }
            return Content("You can not create pizza without login");
        }

        // POST: Pizza/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,int[] ToppingList,string id)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult OrderSession(int OrderId)
        {
            HttpContext.Session.SetInt32("OrderId", OrderId); //set OrderID use to get amount in Payment
          
            return RedirectToAction("Index", "Home"); //jquery redirecto to new url, so this redirectToAction will not work
        }

        // GET: Pizza/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id);
        }

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

                    return RedirectToAction("CreatePizzaIndex");
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

                    return RedirectToAction("CreatePizzaIndex");
                }
            }

            return await Delete(id);
        }
    }
}