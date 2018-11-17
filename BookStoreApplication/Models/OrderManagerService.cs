using BookStoreLibrary;
using BookStoreWebService.Models.BookDB;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class OrderManagerService
    {
        HttpClient client;
        public HttpContext context;
        public OrderManagerService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64966/");

        }
        public void AddToCart(ProductViewModel model)
        {
            List<ProductViewModel> serializedObjects;
            string json = "";
            byte[] ary;

            // json = context.Session.GetString("CatSubCat");
            // SubCategory subcategory = JsonConvert.DeserializeObject<SubCategory>(json);
            bool isavailable = context.Session.TryGetValue("Cart", out ary);
            if (isavailable == false)
            {
                serializedObjects = new List<ProductViewModel>();
                serializedObjects.Add(model);
                serializedObjects = serializedObjects.Distinct().ToList();
                json = JsonConvert.SerializeObject(serializedObjects);
                context.Session.SetString("Cart", json);
            }
            else
            {
                json = context.Session.GetString("Cart");
                serializedObjects = JsonConvert.DeserializeObject<List<ProductViewModel>>(json);
                serializedObjects.Add(model);
                serializedObjects = serializedObjects.Distinct().ToList();
                json = JsonConvert.SerializeObject(serializedObjects);
                context.Session.SetString("Cart", json);
            }

        }
        public List<ProductViewModelCart> ProductCart()

        {

            // List<ProductViewModelCart> serializedObjects;
            string json = "";
            byte[] ary;
            bool isavailable = context.Session.TryGetValue("Cart", out ary);
            json = context.Session.GetString("Cart");
            //serializedObjects = JsonConvert.DeserializeObject<List<ProductViewModelCart>>(json);
            List<ProductViewModelCart> list = JsonConvert.DeserializeObject<List<ProductViewModelCart>>(json);

            List<ProductViewModelCart> result = (from c in list
                                                 select new ProductViewModelCart()
                                                 {
                                                     CategoryId = c.CategoryId,
                                                     Price = c.Price,
                                                     BookId = c.BookId,
                                                     Quantity = c.Quantity,
                                                     SubCategoryId = c.SubCategoryId,
                                                     Title = c.Title
                                                 }).ToList();

            return result.Distinct().ToList();
        }
        public void UpdateCart(int id)
        {
            string json = "";
            byte[] ary;
            bool isavailable = context.Session.TryGetValue("Cart", out ary);
            json = context.Session.GetString("Cart");
            //serializedObjects = JsonConvert.DeserializeObject<List<ProductViewModelCart>>(json);
            List<ProductViewModelCart> list = JsonConvert.DeserializeObject<List<ProductViewModelCart>>(json);

            List<ProductViewModelCart> result = (from c in list
                                                 select new ProductViewModelCart()
                                                 {
                                                     CategoryId = c.CategoryId,
                                                     Price = c.Price,
                                                     BookId = c.BookId,
                                                     Quantity = c.Quantity,
                                                     SubCategoryId = c.SubCategoryId,
                                                     Title = c.Title
                                                 }).ToList();
            var item = result.SingleOrDefault(x => x.BookId == id);
            if (item != null)
                result.Remove(item);
            string updatedList = JsonConvert.SerializeObject(result);
            context.Session.SetString("Cart", updatedList);

        }
        public void StoreFinalProductsInSession(ProductViewModelCart[] model)
        {
            context.Session.Remove("Cart");
            string json = JsonConvert.SerializeObject(model);
            context.Session.SetString("Cart", json);
        }
        public ProductViewModelCart[] GetFinalProductsFromSession()
        {
            string json = context.Session.GetString("Cart");

            ProductViewModelCart[] products = JsonConvert.DeserializeObject<ProductViewModelCart[]>(json);
            return products;
        }
        public int SaveDetails(ProductViewModelCart[] p, string PayMode)
        {
            string InvoiceId;
            string Cid = context.Session.GetString("Customer");
            FinalOrder order = new FinalOrder();
            order.CustomerId = Convert.ToInt32(Cid);
            order.PaymentMethod = PayMode;
            order.products = p;
            string json = JsonConvert.SerializeObject(order);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = client.PostAsync("OrderService/AddOrder", content).Result;
            if (message.IsSuccessStatusCode == true)
            {
                InvoiceId = message.Content.ReadAsStringAsync().Result;
                return Convert.ToInt32(InvoiceId);
            }
            else
            {
                return 0;
            }
        }
        public List<Customer> GetCustomer(int CustomerId)
        {
            HttpResponseMessage message = client.PostAsync("OrderService/GetCustomer/?id=" + CustomerId, null).Result;

            if (message.IsSuccessStatusCode == true)
            {
                string json = message.Content.ReadAsStringAsync().Result.ToString();
                List<Customer> obj = JsonConvert.DeserializeObject<List<Customer>>(json);
                return obj;
            }
            else
                return null; ;
        }
    }
}
