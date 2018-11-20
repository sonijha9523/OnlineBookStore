using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

using BookStoreLibrary;
using BookStoreWebService.Models.BookDB;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class HomeManagerService
    {
        HttpClient client;
        public HttpContext context;
        public HomeManagerService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64966/");

        }
        
        public async Task<int> AddRecord(Customer c)
        {
           
                string json = JsonConvert.SerializeObject(c);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/AddNew", content);
            if (message.IsSuccessStatusCode == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public async Task<int> ValidateUser(Credentials credentials)
        {
            string customerId;
            string json = JsonConvert.SerializeObject(credentials);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/Authentication", content);
            if (message.IsSuccessStatusCode == true)
            {
                byte[] ary;
                customerId = await message.Content.ReadAsStringAsync();
                bool isavailable = context.Session.TryGetValue("Customer", out ary);
                if (isavailable == false)
                {
                    context.Session.SetString("Customer", customerId);
                }
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public async Task<int> ValidateAdmin(Credentials credentials)
        {
            
            string customerId;
            string json = JsonConvert.SerializeObject(credentials);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/AuthenticationAdmin", content);
            if (message.IsSuccessStatusCode == true)
            {
                customerId = message.Content.ReadAsStringAsync().Result;
                return 1;
            }
            else
            {
                return 0;
            }
        }



        public async Task AddBookRecord(Book b)
        {
            string json = JsonConvert.SerializeObject(b);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/AddNewBook", content);
      
        }
        public async Task<int> RemoveBookRecord(int id)
        {
            string json = JsonConvert.SerializeObject(id);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/RemoveBook", content);
            if (message.IsSuccessStatusCode == true)
            {
                return 1;
            }
            else
                return 0;
        }
       
        public async Task EditBookRecord(Book b)
        {
            string json = JsonConvert.SerializeObject(b);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/EditNewBook", content);
           
        }
        public async Task<List<Book>> GetAllBooks()
        {

            HttpResponseMessage message =await client.PostAsync("AdminService/AllBooks", null);

            if (message.IsSuccessStatusCode == true)
            {
                var result= await message.Content.ReadAsStringAsync();
                string json = result.ToString();
                List<Book> allcategory = JsonConvert.DeserializeObject<List<Book>>(json);
                return allcategory;
            }
            else
                return null; ;
        }
        public async Task<List<Book>> ReorderLevel()
        {

            HttpResponseMessage message = await client.PostAsync("AdminService/ReorderLevel", null);

            if (message.IsSuccessStatusCode == true)
            {
                var result= message.Content.ReadAsStringAsync().Result.ToString();
                string json = result.ToString();
                List<Book> book = JsonConvert.DeserializeObject<List<Book>>(json);
                return book;
            }
            else
                return null; ;
        }
        public async Task<int> UpdateQuantity(ReorderLevelDetails[] r)
        {
            string json = JsonConvert.SerializeObject(r);
            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage message = await client.PostAsync("AdminService/UpdateQuantities", content);
            if (message.IsSuccessStatusCode == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
        public bool CheckSession()
        {
            byte[] ary;
            bool isavailable = context.Session.TryGetValue("Customer", out ary);
            return isavailable;
        }
    }
}
