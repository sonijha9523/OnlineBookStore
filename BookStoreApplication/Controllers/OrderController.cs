using System;
using System.Collections.Generic;
using BookStoreApplication.Models;
using BookStoreLibrary;
using BookStoreWebService.Models;
using BookStoreWebService.Models.BookDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebApplication2.Models;

namespace BookStoreApplication.Controllers
{
    public class OrderController : Controller
    {
        OrderManagerService BookAppservice;
        BookService service;
        ILogger<OrderController> log;
        public OrderController(ILogger<OrderController> log)
        {
            this.log = log;
            BookAppservice = new OrderManagerService();
            service = new BookService();
        }
        [HttpPost][HttpGet]
        [ErrorFilter]
        public IActionResult AddToCart(ProductViewModel model)
        {
            try {
                log.LogInformation("Executing AddToCart Method..");
                log.LogInformation("This is a Test Message");
            }
            catch(Exception e) {
                log.LogCritical(e.Message);
                log.LogInformation("Executed AddToCart Method..");
            }
            
            BookAppservice.context = HttpContext;

            BookAppservice.AddToCart(model);

            string json = HttpContext.Session.GetString("CatSubCat");
            SubCategory subcategory = JsonConvert.DeserializeObject<SubCategory>(json);
            return RedirectToAction("SearchBooks", "Book", subcategory);


        }
        [HttpGet][HttpPost]
        [ErrorFilter]
        public IActionResult ViewCart()
        {

            BookAppservice.context = HttpContext;
            List<ProductViewModelCart> result = BookAppservice.ProductCart();
            try
            {
                if (result.Capacity>0)
                {
                    log.LogInformation("Executing ViewCart Method..");
                    log.LogInformation("This is a Test Message");
                    BookAppservice.context = HttpContext;
                    ViewData["products"] = result;
                }
                else
                {

                }
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed ViewCart Method..");
            }
         
           
           
            return View(result);
        }
        [HttpPost][HttpGet]
        [ErrorFilter]
        public IActionResult UpdateCart(int id)
        {
            BookAppservice.context = HttpContext;
            BookAppservice.UpdateCart(id);
          return   RedirectToAction("ViewCart");
        }
        [HttpGet]
        [HttpPost]
        [ErrorFilter]
        public IActionResult ProcessOrder(ProductViewModelCart[] p)
        {
            try
            {
                log.LogInformation("Executing ProcessOrder Method..");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed ProcessOrder Method..");
            }
            /* List<ProcessOrder> productList = new List<ProcessOrder>();
             foreach (var i in p)
             {
                 ProcessOrder obj = new ProcessOrder();
                 obj.BookId = i.BookId;
                 obj.Price = i.Price;
                 obj.sum = (int)(i.Price * i.Quantity);
                 obj.Quantity = i.Quantity;
                 obj.Title = i.Title;
                 //if(productList.Find(obj))
                 productList.Add(obj);

             }*/
            BookAppservice.context = HttpContext;
            BookAppservice.StoreFinalProductsInSession(p);
             ViewData["products"] = p;

            return View();
        }

        [HttpGet]
        [HttpPost]
        [ErrorFilter]
        public IActionResult Payment()
        {
            try
            {
                log.LogInformation("Executing ProcessOrder Method..");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed ProcessOrder Method..");
            }
            List<ProcessOrder> productList = new List<ProcessOrder>();
            BookAppservice.context = HttpContext;
            ProductViewModelCart[] p = BookAppservice.GetFinalProductsFromSession();
            //foreach (var i in p)
            //{
            //    ProcessOrder obj = new ProcessOrder();
            //    obj.BookId = i.BookId;
            //    obj.Price = i.Price;
            //    obj.sum = (int)(i.Price * i.Quantity);
            //    obj.Quantity = i.Quantity;
            //    obj.Title = i.Title;
            //    productList.Add(obj);

            //}
            // BookAppservice.StoreFinalProductsInSession(p);
             ViewData["products"] = p;
            // TempData["SelectedProducts"] = p;
            // return RedirectToAction("Pay", "Order");
            return View();
        }
        [HttpGet]
        [HttpPost]
        [ErrorFilter]
        public IActionResult Pay()
        {
            try
            {
                log.LogInformation("Executing ProcessOrder Method..");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed ProcessOrder Method..");
            }
            List<ProcessOrder> productList = new List<ProcessOrder>();
            BookAppservice.context = HttpContext;
            ProductViewModelCart[] p = BookAppservice.GetFinalProductsFromSession();
            //foreach (var i in p)
            //{
            //    ProcessOrder obj = new ProcessOrder();
            //    obj.BookId = i.BookId;
            //    obj.Price = i.Price;
            //    obj.sum = (int)(i.Price * i.Quantity);
            //    obj.Quantity = i.Quantity;
            //    obj.Title = i.Title;
            //    productList.Add(obj);

            //}
            // BookAppservice.StoreFinalProductsInSession(p);
            ViewData["products"] = p;
            //TempData["SelectedProducts"] = p;
            return View();
        }

        [HttpGet]
        [HttpPost]
        [ErrorFilter]
        public IActionResult Success(string PayMode)
        {
            int InvoiceId;
            try
            {
                log.LogInformation("Executing ProcessOrder Method..");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed ProcessOrder Method..");
            }
            List<ProcessOrder> productList = new List<ProcessOrder>();
            BookAppservice.context = HttpContext;
            ProductViewModelCart[] p = BookAppservice.GetFinalProductsFromSession();
            InvoiceId = BookAppservice.SaveDetails(p,PayMode);
            string Cid = HttpContext.Session.GetString("Customer");
            int CustomerId = Convert.ToInt32(Cid);
            List<Customer> c = BookAppservice.GetCustomer(CustomerId);
            ViewData["Customer"] = c;
            ViewData["products"] = p;
            ViewData["Invoice"] = InvoiceId;
            ViewData["PaymentMethod"] = PayMode;
            //TempData["SelectedProducts"] = p;
            HttpContext.Session.Remove("Cart");
            return View();
        }
        [HttpGet]
        [ErrorFilter]
        public IActionResult UserProfile()
        {
           
            try
            {
                log.LogInformation("Executing ProcessOrder Method..");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed ProcessOrder Method..");
            }
            string Cid = HttpContext.Session.GetString("Customer");
            int CustomerId = Convert.ToInt32(Cid);
            List<Customer> c = BookAppservice.GetCustomer(CustomerId);
            ViewData["Customer"] = c;
            return View();
        }
    }
}