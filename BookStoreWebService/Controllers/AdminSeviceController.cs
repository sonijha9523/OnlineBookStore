using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using BookStoreLibrary;
using BookStoreWebService.Models;
using BookStoreWebService.Models.BookDB;

namespace BookStoreWebService.Controllers
{
    [Route("AdminService")]
    [ApiController]
    public class AdminSeviceController : ControllerBase
    {
        AdminService service;
        public AdminSeviceController()
        {
            service = new AdminService();
        }
        [HttpPost]
        [Route("AddNew")]
        public IActionResult AddNew(Customer customer)
        {
            int result = service.AddNew(customer);
            if(result==0)
            {
                return NotFound(result);
            }
            else
            {
                return Ok(result);
            }
        }
       
        [HttpPost]
        [Route("Authentication")]
        public IActionResult Authentication(Credentials credentials)
        {
            int result = service.Authentication(credentials);
            if (result == 0)
            {
                return NotFound();
            }
            else
                return Ok(result);
        }
     
        [HttpPost]
        [Route("AddNewBook")]
        public IActionResult AddNewBook(Book book)
        {
            int result = service.AddNewBook(book);
            return Ok(result);
        }
        [HttpGet]
        [Route("RemoveBook")]
        public IActionResult RemoveBook(int id)
        {
            int result = service.RemoveBook(id);
             return Ok(result);
        }
    
        [Route("EditNewBook")]
        public IActionResult EditNewBook(Book book)
        {
            int result = service.EditNewBook(book);
            return Ok(result);
        }

        [HttpPost]
        [Route("AllBooks")]
        public List<Book> AllBooks()
        {

            List<Book> allbooks = service.AllBooks();
            return allbooks;

        }
        [HttpPost]
        [Route("ReorderLevel")]
        public List<Book> ReoderLevel()
        {

            List<Book> allbooks = service.ReorderLevel();
            return allbooks;

        }
        [HttpPost]
        [HttpGet]
        [Route("UpdateQuantities")]
        public IActionResult UpdateQuantity([FromBody]ReorderLevelDetails[] r)
        {

            int result = service.UpdateQuantity(r);
            return Ok(result);

        }
    }
}
