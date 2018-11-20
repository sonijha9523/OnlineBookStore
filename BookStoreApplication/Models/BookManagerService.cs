using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

using BookStoreWebService.Models.BookDB;
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
        public async Task<List<Category>> SelectCategory()
        {
            HttpResponseMessage message =  await client.PostAsync("BookService/SelCategory", null);

            if (message.IsSuccessStatusCode == true)
            {
                var result = await message.Content.ReadAsStringAsync();
                string json = result.ToString();

                   
                List<Category> allcategory = JsonConvert.DeserializeObject<List<Category>>(json);
                return allcategory;
            }
            else
                return null;
        }
     
        public async Task<List<Book>> GetAllBooks()
        {

            HttpResponseMessage message = await client.PostAsync("BookService/AllBooks", null);

            if (message.IsSuccessStatusCode == true)
            {
              var result = await message.Content.ReadAsStringAsync();
                string json = result.ToString();
                List<Book> allcategory = JsonConvert.DeserializeObject<List<Book>>(json);
                return allcategory;
            }
            else
                return null; ;
        }
   
        public async Task<List<Book>> GetBookById(int id)
        {
            HttpResponseMessage message = await client.PostAsync("BookService/GetBookById/?id=" + id, null);

            if (message.IsSuccessStatusCode == true)
            {
                var result= message.Content.ReadAsStringAsync();
                string json = result.ToString();
              List<Book> obj = JsonConvert.DeserializeObject<List<Book>>(json);
                return obj;
            }
            else
                return null; ;

        }
        public async Task<List<Book>> GetAllBookById(int id)
        {
            HttpResponseMessage message = await client.PostAsync("BookService/GetAllBookByCat/?id=" + id, null);

            if (message.IsSuccessStatusCode == true)
            {
               var result =message.Content.ReadAsStringAsync();
                string json = result.ToString();
                List<Book> obj = JsonConvert.DeserializeObject<List<Book>>(json);
                return obj;
            }
            else
                return null; ;

        }
    }


}
