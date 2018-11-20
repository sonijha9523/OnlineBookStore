using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;

using BookStoreApplication.Models;
using BookStoreLibrary;
using BookStoreWebService.Models;
using BookStoreWebService.Models.BookDB;
using WebApplication2.Models;
using System.Threading.Tasks;

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

            BookAppservice.AddToCartDetailsInSession(model);

            string json = HttpContext.Session.GetString("CatSubCat");
            SubCategory subcategory = JsonConvert.DeserializeObject<SubCategory>(json);
            return RedirectToAction("SearchBooks", "Book", subcategory);


        }
        [HttpGet][HttpPost]
        [ErrorFilter]
        public IActionResult ViewCart()
        {

            BookAppservice.context = HttpContext;
            List<ProductViewModelCart> result = BookAppservice.FetchBooksFromCart();
            try
            {
                if (result.Capacity>0)
                {
                    log.LogInformation("Executing ViewCart Method..");
                    log.LogInformation("This is a Test Message");
                    BookAppservice.context = HttpContext;
             //      ViewData["products"] = result;
                }
                else
                {

                }
                ViewData["products"] = result;

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
            BookAppservice.UpdateCartInSession(id);
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
           
            BookAppservice.context = HttpContext;
            BookAppservice.StoreFinalProductsInSession(p);
             ViewData["products"] = p;

            return View();
        }

        [HttpGet]
        [HttpPost]
        [ErrorFilter]
        public async Task<IActionResult> Payment()
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
            string Cid = HttpContext.Session.GetString("Customer");
            int CustomerId = Convert.ToInt32(Cid);
            List<Customer> c = await BookAppservice.GetCustomerDetail(CustomerId);
            ViewData["Customer"] = c;
            ViewData["products"] = p;
           
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
          
            ViewData["products"] = p;
           
            return View();
        }

        [HttpGet]
        [HttpPost]
        [ErrorFilter]
        public async Task<IActionResult> Success(string PayMode)
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
            InvoiceId = await BookAppservice.SaveDetails(p,PayMode);
            string Cid = HttpContext.Session.GetString("Customer");
            int CustomerId = Convert.ToInt32(Cid);
            List<Customer> c =await  BookAppservice.GetCustomerDetail(CustomerId);
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
        public async Task<IActionResult> UserProfile()
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
            List<Customer> c = await BookAppservice.GetCustomerDetail(CustomerId);
            ViewData["Customer"] = c;
            return View();
        }
    }
}