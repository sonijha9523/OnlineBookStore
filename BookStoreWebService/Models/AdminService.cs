using System;
using System.Collections.Generic;
using System.Linq;

using BookStoreWebService.Models.BookDB;
using BookStoreLibrary;

namespace BookStoreWebService.Models
{
    
    public class AdminService
    {
        BookStoreDBContext context;
        public AdminService()
        {
            context = new BookStoreDBContext();
        }
        public int AddNew(Customer customer)
        {
            var query=(from c in context.Customer  where c.Email == customer.Email select c).Any();
            var check = query;
            if (check == false)
            {
                context.Customer.Add(customer);
                int result = context.SaveChanges();
                return result;
            }
            else
            {
                return 0;
            }
        }
        public int AddNewOrder(Orders order)
        {
                context.Orders.Add(order);
                int result = context.SaveChanges();
                return result;
        }
        public int Authentication(Credentials credentials)
        {
            var result = (from c in context.Customer where c.Email == credentials.Email && c.Password == credentials.Password select c.CustomerId).FirstOrDefault();
            return result;
        }
        public int AuthenticationAdmin(Credentials credentials)
        {
            if(credentials.Email=="Admin123@gmail.com" && credentials.Password=="Admin@123")
            {
               
                return 1;
            }
           else
            {
                return 0;
            }
            
        }
        public int AddNewBook(Book book)
        {
            context.Book.Add(book);
            int result = context.SaveChanges();
            return result;
        }
       
        public int RemoveBook(int id)
        {
            var result = (from b in context.Book where b.BookId == id select b).SingleOrDefault();
            if (result != null)
            {       context.Book.Remove(result);
                   context.SaveChanges();
                return 1;
            }

            return 0;
        }
        public int EditNewBook(Book book)
        {
            context.Book.Add(book);
            var result = context.SaveChanges();
            return result;

        }
        public List<Book> AllBooks()
        {

            var result = (from b in context.Book select b).ToList();
            return result;
        }
        public List<Book> ReorderLevel()
        {
            var result = (from b in context.Book where b.BookQuantity <= 50 select b).ToList();
            return result;
        }
        public int UpdateQuantity(ReorderLevelDetails[] r)
        {
            int Quantity = 0;
            ProductOrderDetails[] ary = new ProductOrderDetails[r.Length];
            
            foreach (var i in r)
            {
                Quantity += i.Quantity;

            }
            ProductOrder o = new ProductOrder()
            {
                ProductOrderDate = DateTime.Now,
                ProductOrderQuantity = Quantity,
            };
            if(o.ProductOrderQuantity!=0)
            {
                context.ProductOrder.Add(o);
                context.SaveChanges();
            }
            for (int j = 0; j < r.Length; j++)
                {
                ary[j] = new ProductOrderDetails()
                {
                    ProductOrderQuantity = r[j].Quantity,
                    BookId = r[j].BookId,
                    RequestId = o.RequestId
                };
                if(ary[j].ProductOrderQuantity!=0)
                {
                    context.ProductOrderDetails.AddRange(ary[j]);
                    context.SaveChanges();
                }
            }
            return o.RequestId ;
        }
    }
}
