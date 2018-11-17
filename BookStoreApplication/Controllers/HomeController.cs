using System;
using System.Collections.Generic;
using BookStoreApplication.Models;
using BookStoreLibrary;
using BookStoreWebService.Models;
using BookStoreWebService.Models.BookDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;

namespace BookStoreApplication.Controllers
{

    public class HomeController : Controller
    {
        ILogger<HomeController> log;
        HomeManagerService service;
        BookService service1;
        BookManagerService serviceBook;
           
        public HomeController(ILogger<HomeController> log)
        {
            service1 = new BookService();
            serviceBook = new BookManagerService();
            service = new HomeManagerService();
            this.log = log;
            
        }
        [HttpGet][HttpPost]
        public IActionResult Index(int id)
        {
            List<Book> AllBookList;


            try
            {
                log.LogInformation("Executing GetBooks method");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed GetBooks Method..");
            }
            ViewData["Categories"] = serviceBook.SelectCategory();

            if (id>0)
            {
                AllBookList = serviceBook.GetAllBookById(id);
                return View(AllBookList);
            }
            else
            {
                AllBookList = serviceBook.GetAllBooks();
                return View(AllBookList);
            }
            
          
          
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ErrorFilter]
        public IActionResult Register(Customer c)
        {
            var result=service.AddRecord(c);
            if (result == 0)
            {
                ModelState.AddModelError("Email", "EmailId already Exist.. Try with another EmailId...");
                return View("Register");
            }
            try
            {
                log.LogInformation("Executing Register method");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed Register Method..");
            };
            return RedirectToAction("Login");
            
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
      
        public IActionResult Login(Credentials credentials)
        {
            try
            {
                log.LogInformation("Executing Login method");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed Login Method..");
            }


            service.context = HttpContext;
            int result = service.ValidateUser(credentials);
      
            if (result == 0)
            {
                ModelState.AddModelError("Password", "Incorrect UserId Or Password..........");
                return View("Login", credentials);
            }
    
            return RedirectToAction("GetCategory","Book", new { area = "" });

        }
        public IActionResult LoginAdmin(Credentials credentials)
        {
            try
            {
                log.LogInformation("Executing Login method");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed Login Method..");
            }


            service.context = HttpContext;
            int result = service.ValidateAdmin(credentials);

            if (result == 0)
            {
                ModelState.AddModelError("Password", "Incorrect UserId Or Password..........");
                return View("LoginAdmin", credentials);
            }
            return RedirectToAction("Admin", "Home", new { area = "" });

        }
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddBook(Book b)
        {
            try
            {
                log.LogInformation("Executing GetCategoy method");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed GetCategoy Method..");
            }

            service.AddBookRecord(b);
            service.context = HttpContext;
            return RedirectToAction("AddBook");
        }
        [HttpGet]
        [ErrorFilter]
        public IActionResult RemoveBook(int id)
        {
            service.RemoveBookRecord(id);
            return RedirectToAction("GetBooks");
        }
        [ErrorFilter]
        public IActionResult Admin()
        {
            return View("Admin");
        }
        [ErrorFilter]
        public IActionResult SaveChanges(Book b)
        {
           return View();
        }
        public IActionResult GetBooks()
        {
            List<Book> AllBookList = service.GetAllBooks();
            
            return View(AllBookList);
        }
        [ErrorFilter]
        public IActionResult About()
        {
            return View();
        }
        [ErrorFilter]
        public IActionResult Contact()
        {

            return View();
        }
        [ErrorFilter]
        public IActionResult ReorderLevel()
        {
            try
            {
                log.LogInformation("Executing GetBooks method");
                log.LogInformation("This is a Test Message");
            }
            catch (Exception e)
            {
                log.LogCritical(e.Message);
                log.LogInformation("Executed GetBooks Method..");
            }
            List<Book> AllBookList = service.ReorderLevel();
            ViewData["Books"] = AllBookList;
            return View();
        }
        public IActionResult UpdateQuantity(ReorderLevelDetails[] r)
        {
            service.UpdateQuantity(r);
            return RedirectToAction("ReorderLevel"); ;
        }
        public IActionResult Logout()
        {
            service.context = HttpContext;
            bool SessionStatus = service.CheckSession();
            if (SessionStatus)
            {
                HttpContext.Session.Clear();

            }

            return View("Login");
        }
    }
}