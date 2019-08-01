using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Cors;
using Entities;


namespace PizzaOrderingUI.Controllers
{

    public class CustomerController : Controller
    {
        
        public ActionResult GetCustomer()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                return View();
            }

            return Content("You have to login");
        }

        public ActionResult Register()
        {
            return View();
        }





        public ActionResult Login()
        {

            return View();
        }

        public ActionResult DeleteCustomer()
        {
            return View();
        }


       
        // GET: Customer
        public string Index()
        {
            //HttpClient client = new HttpClient();
            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));
            //var apiUrl = "api/Customers";
            //var stringTask = client.GetStringAsync(_url + apiUrl);
            //var res = stringTask.Result;

            //return res;

            return "Nothing in this page";


        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // GET: Customer/Edit/5
        public ActionResult Edit(int id,Customer customer)
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                customer.CustomerId = Convert.ToInt32(HttpContext.Session.GetString("CustomerId"));
             }
            
            return View(customer);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear(); //remove current session
            return RedirectToAction("Login", "Customer");//redirect to login
        }

        public IActionResult Welcome()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.UserName = HttpContext.Session.GetString("UserName"); //use to display username for upper right nav 

                ViewBag.CustomerId = HttpContext.Session.GetString("CustomerId");//determine differnt nav view for login and logout
                //also use CustomerId to determine if the user is login or not

                return RedirectToAction($"Edit/{ViewBag.CustomerId}", "Customer");


            }
            else
            {

                return RedirectToAction("Customers", "Login");

            }
        }



        public IActionResult Session(int id, string Username)
        {
            HttpContext.Session.SetString("CustomerId", id.ToString());//set CustomerId value use in Welcome Action
            HttpContext.Session.SetString("UserName", Username.ToString()); //set UserName value use in Welcome Action
            return RedirectToAction("Index", "Home"); //redirect to home
 
        }

        public IActionResult OrderSession(int OrderId)
        {
            HttpContext.Session.SetInt32("OrderId", OrderId);
            return View();
        }
        public ActionResult LoginFailed()
        {
            ViewBag.LoginFailed = $"Failed, incorrect UserName or Password";
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index", "Home");//redirect to Home
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}