using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using BookStoreLibrary;
using BookStoreWebService.Models;
using BookStoreWebService.Models.BookDB;
namespace BookStoreWebService.Controllers
{
    [Route("OrderService")]
    [ApiController]
    public class OrderServiceController : ControllerBase
    {
        OrderService service;
        public OrderServiceController()
        {
            service = new OrderService();
        }
        [HttpPost]
        [Route("AddOrder")]
        public IActionResult AddOrder(FinalOrder order)
        {
            int result = service.AddOrder(order);
                return Ok(result);
        }
        [HttpPost]
        [Route("GetCustomer")]
        public List<Customer> GetCustomer(int id)
        {
            List<Customer> obj = service.GetCustomer(id);
            return obj;
        }
    }
}