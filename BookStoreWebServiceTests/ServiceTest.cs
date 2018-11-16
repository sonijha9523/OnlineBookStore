using BookStoreLibrary;
using BookStoreWebService.Controllers;
using BookStoreWebService.Models.BookDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreWebServiceTests
{
    [TestClass]
    public class WebServiceTests
    {
        public static int customerId;
        public static int bookId;
        public static int orderId;
        public static int OrderDetailId;
        public static int InvoiceNo;
        BookStoreDBContext context;
        AdminSeviceController controller;
        BookServiceController controller1;
        OrderServiceController controller2;
        public WebServiceTests()
        {
            context = new BookStoreDBContext();
            controller = new AdminSeviceController();
            controller1 = new BookServiceController();
            controller2 = new OrderServiceController();
        }
        [TestMethod]
        public void TestMethodGetSubCategory()
        {
            int id = 500;
            var result = controller1.SelSubCategory(id);
            Assert.IsNotNull(result);
        }
        //[TestMethod]
        //public void TestForPositiveCountSubCategory()
        //{
        //    var result = controller.GetSubCat();
        //    Assert.IsTrue(result.Count > 0);
        //}
        //[TestMethod]
        //public void TestForPositiveCountGetBooks()
        //{
        //    var result = controller.AllBooks();
        //    Assert.IsTrue(result.Count > 0);
        //}

        //----------------LOGIN--------------------
        [TestMethod]
        public void AuhenticationSuccess()
        {
            Credentials obj = new Credentials()
            {
                Email = "gitanjali3@gmail.com",
                Password = "Gitanjali@123"
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        [TestMethod]
        public void WrongCredentials()
        {
            Credentials obj = new Credentials()
            {
                Email = "gitanjali@12334",
                Password = "gitanjali@@3677"
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void WrongEmailId()
        {
            Credentials obj = new Credentials()
            {
                Email = "gitanjali",
                Password = "Gitanjali@123"
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void WrongPassword()
        {
            Credentials obj = new Credentials()
            {
                Email = "gitanjali3@gmail.com",
                Password = "gitanjali@@3677"
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void UserIdNull()
        {
            Credentials obj = new Credentials()
            {
                Email = null,
                Password = "gitanjali@@3677"
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void PasswordNull()
        {
            Credentials obj = new Credentials()
            {
                Email = "gitanjali3@gmail.com",
                Password = null
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        [TestMethod]
        public void NullCredentials()
        {
            Credentials obj = new Credentials()
            {
                Email = null,
                Password = null
            };
            var result = controller.Authentication(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        //----------------REGISTRATION---------------------------
        [TestMethod]
        public void SuccessAccountCreationTestMethod()
        {
            Customer obj = new Customer()
            {
                Email = "Jerry12345@gmail.com",
                CustomerName = "Anuj",
                Address = "aaaa",
                Password = "Anuj@123",
                MobileNumber = "1111111111",
            };
            var result = controller.AddNew(obj);
            customerId = obj.CustomerId;
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        [TestMethod]
        public void NotSuccessAcountCreationTestMethod()
        {
            Customer obj = new Customer()
            {
                Email = "Gitanjali3@gmail.com",
                CustomerName = "Gitanjali",
                Address = "kkkkk",
                Password = "Sakshi@123",
                MobileNumber = "2222222222",
            };
            var result = controller.AddNew(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundObjectResult));
        }
        //----------------Orders---------------------------
        [TestMethod]
        public void Orders()
        {
            FinalOrder obj = new FinalOrder()
            {
                PaymentMethod = "COD",
                products = new ProductViewModelCart[]
                {
                    new ProductViewModelCart(){
                         BookId =204,
                         Price = 400,
                         Quantity = 8,
                         Title = "Final Test",
                    }
                },
                CustomerId = 111
            };
            var result = controller2.AddOrder(obj) as OkObjectResult;
            InvoiceNo = (int)result.Value;
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        [TestMethod]
        public void ProductOrders()
        {
            ReorderLevelDetails[] obj = new ReorderLevelDetails[]
            {
               new ReorderLevelDetails() { BookId=201, Quantity=10}
            };
            var result = controller.UpdateQuantity(obj);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        [TestMethod]
        public void AlreadyExistingUserIdTestMethod()
        {
            Customer obj = new Customer()
            {
                Email = "Gitanjali3@gmail.com",
                CustomerName = "Gitanjali",
                Address = "kkkkk",
                Password = "Sakshi@123",
                MobileNumber = "2222222222",
            };
            var result = controller.AddNew(obj);
            Assert.IsInstanceOfType(result, typeof(NotFoundObjectResult));
        }
        [TestMethod]
        public void AddToCartTestMethod()
        {

        }
        [TestMethod]
        public void AddToCartAsGuestTestMethod()
        {

        }
        [TestMethod]
        public void AddBookRecordTestMethod()
        {
            Book obj = new Book
            {
                BookTitle = "TestBook1",
                BookQuantity = 40,
                Price = 600,
                CategoryId = 404,
                SubCategoryId = 504,
                SupplierId = 1000
            };
            var result = controller.AddNewBook(obj);
            bookId = obj.BookId;
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));

        }
        //[TestMethod]
        //public void RemoveBookRecordTestMethod()
        //{
        //    Book obj = new Book
        //    {
        //        BookTitle = "Book2",
        //        BookQuantity = 40,
        //        Price = 600,
        //        CategoryId = 404,
        //        SubCategoryId = 504,
        //        SupplierId = 1000
        //    };
        //    var result = controller.AddNewBook(obj);
        //    Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        //}
        [TestMethod]
        public void SearchingBookTestMethod()
        {
            SubCategory obj = new SubCategory
            {
                CategoryId = 400,
                SubCategoryId = 505
            };
            var result = controller1.SearchBooks(obj);
            Assert.IsInstanceOfType(result, typeof(OkObjectResult));
        }
        //[TestCleanup]
        //public void AccountCreationCleanUp()
        //{
           
        //    var customer = context.Customer.SingleOrDefault(c => c.CustomerId == customerId);
        //    context.Customer.Remove(customer);
        //    context.SaveChanges();
        //}
        [ClassCleanup]
        public static void ClassClean()
        {
            BookStoreDBContext context = new BookStoreDBContext();
            Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@");
            var customer = context.Customer.SingleOrDefault(c => c.CustomerId == customerId);
            var book = context.Book.SingleOrDefault(b => b.BookId == bookId);
            context.Customer.Remove(customer);
            context.Book.Remove(book);
            

            //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
            Payment p= context.Payment.SingleOrDefault(c => c.InvoiceNumber == InvoiceNo);
            var orderdetails=context.OrderDetails.Where(c => c.OrderId == p.OrderId).ToArray();

            context.OrderDetails.RemoveRange(orderdetails);
            context.Payment.Remove(p);
            Orders order = context.Orders.SingleOrDefault(c => c.OrderId == p.OrderId);
            context.Orders.Remove(order);
            context.SaveChanges();
        }
    }
}
