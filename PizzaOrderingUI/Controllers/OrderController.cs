using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PizzaOrderingUI.Controllers
{
    public class OrderController : Controller
    {
        private string _url = "http://localhost:54241/";

        // GET: Order
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString("CustomerId") != null)
            {
                IEnumerable<Order> orders = null;
                var custId = HttpContext.Session.GetString("CustomerId");
                using (var client = new HttpClient())
                {
                    var apiUrl = "api/orders";
                    client.BaseAddress = new Uri(_url + apiUrl);
                    //HTTP GET
                    // PizzaAPI.Controllers.CustomerController c = new PizzaAPI.Controllers.CustomerController(_context);
                    var responseTask = client.GetAsync("orders/customer/" + custId);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var readTask = result.Content.ReadAsAsync<IList<Order>>();
                        readTask.Wait();
                        orders = readTask.Result;
                    }
                    else //web api sent error response
                    {
                        //log response status here..
                        ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                    }
                }
                return View(orders);
            }
            else
            {
                return RedirectToAction("Login", "Customer");
            }
            
           
        }

        // GET: Order/Details/5
        public ActionResult Details(int? id)
        {
            Order order = null;
            using (var client = new HttpClient())
            {
                var apiUrl = "api/orders";
                client.BaseAddress = new Uri(_url + apiUrl);
                //HTTP GET
                // PizzaAPI.Controllers.CustomerController c = new PizzaAPI.Controllers.CustomerController(_context);
                var responseTask = client.GetAsync("orders/" + id);
                responseTask.Wait();
                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<Order>();
                    readTask.Wait();
                    order = readTask.Result;
                }
                else //web api sent error response
                {
                    //log response status here..
                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }

            return View(order);
        }


        // GET: Order/Edit/5
        public IActionResult Edit(int? id)
        {
            return Details(id);
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Order order)
        {

            using (var client = new HttpClient())
            {
                var apiUrl = "api/orders";
                client.BaseAddress = new Uri(_url + apiUrl);

                //HTTP POST
                var putTask = client.PutAsJsonAsync("orders/" + id, order);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(order);


        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return Details(id);
        }

        // POST: Order/Delete/5
        [HttpPost]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id)
        {
            using (var client = new HttpClient())
            {

                //HTTP DELETE
                var apiUrl = "api/orders";
                client.BaseAddress = new Uri(_url + apiUrl);


                var deleteTask = client.DeleteAsync("orders/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return Delete(id);
        }
    }
}