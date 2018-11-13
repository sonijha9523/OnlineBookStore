using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreLibrary;
using BookStoreWebService.Models;
using BookStoreWebService.Models.BookDB;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreWebService.Controllers
{
    [Route("OrderService")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderService service;
        public OrderController()
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