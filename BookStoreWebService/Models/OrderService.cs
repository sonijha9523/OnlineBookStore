using System;
using System.Collections.Generic;
using System.Linq;

using BookStoreLibrary;
using BookStoreWebService.Models.BookDB;

namespace BookStoreWebService.Models
{
    public class OrderService
    {
        BookStoreDBContext context;
        public OrderService()
        {
            context = new BookStoreDBContext();
        }
        public int AddOrder(FinalOrder order)
        {
            int sum=0, Quantity=0;
            OrderDetails[] ary = new OrderDetails[order.products.Length];
            foreach (var i in order.products)
            {
                sum += (int)i.Price * i.Quantity;
                Quantity += i.Quantity;

            }
            Orders o = new Orders()
            {
                OrderDate = DateTime.Now,
                OrderAmount = sum,
                OrderQuantity = Quantity,
                CustomerId= order.CustomerId,
            };
            
            
            context.Orders.Add(o);
            context.SaveChanges();
            for (int j = 0; j < order.products.Length; j++)
            {
                ary[j] = new OrderDetails()
                {
                    OrderId = o.OrderId,
                    BookId = order.products[j].BookId,
                    Quantity = order.products[j].Quantity,
                    OrderPrice = order.products[j].Price

                };
            }
            context.OrderDetails.AddRange(ary);
            context.SaveChanges();

            Payment p = new Payment()
            {
                PaymentMethod = order.PaymentMethod,
                OrderId = o.OrderId
            };
             context.Payment.Add(p);
            context.SaveChanges();
            Book temp;
            foreach (var i in order.products)
            {
                temp = context.Book.SingleOrDefault(c => c.BookId == i.BookId);
                temp.BookQuantity -= i.Quantity;
            }
            context.SaveChanges();
            return p.InvoiceNumber;

        }
        public List<Customer> GetCustomer(int id)
        {
            var result = (from c in context.Customer where c.CustomerId == id select c).ToList();
            return result;

        }
    }
}
