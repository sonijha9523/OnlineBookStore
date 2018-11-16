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
    public class BookManagerService
    {
        HttpClient client;
        public HttpContext context;
        public BookManagerService()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:64966/");

        }
        public List<Category> SelectCategory()
        {
            HttpResponseMessage message = client.PostAsync("BookService/SelCategory", null).Result;

            if (message.IsSuccessStatusCode == true)
            {
                string json = message.Content.ReadAsStringAsync().Result.ToString();
                List<Category> allcategory = JsonConvert.DeserializeObject<List<Category>>(json);
                return allcategory;
            }
            else
                return null;
        }
     
        public List<Book> GetAllBooks()
        {

            HttpResponseMessage message = client.PostAsync("BookService/AllBooks", null).Result;

            if (message.IsSuccessStatusCode == true)
            {
                string json = message.Content.ReadAsStringAsync().Result.ToString();
                List<Book> allcategory = JsonConvert.DeserializeObject<List<Book>>(json);
                return allcategory;
            }
            else
                return null; ;
        }
        public List<Book> GetBookById(int id)
        {
            HttpResponseMessage message = client.PostAsync("BookService/GetBookById/?id=" + id, null).Result;

            if (message.IsSuccessStatusCode == true)
            {
                string json = message.Content.ReadAsStringAsync().Result.ToString();
              List<Book> obj = JsonConvert.DeserializeObject<List<Book>>(json);
                return obj;
            }
            else
                return null; ;

        }
        public List<Book> GetAllBookById(int id)
        {
            HttpResponseMessage message = client.PostAsync("BookService/GetAllBookByCat/?id=" + id, null).Result;

            if (message.IsSuccessStatusCode == true)
            {
                string json = message.Content.ReadAsStringAsync().Result.ToString();
                List<Book> obj = JsonConvert.DeserializeObject<List<Book>>(json);
                return obj;
            }
            else
                return null; ;

        }
    }


}
