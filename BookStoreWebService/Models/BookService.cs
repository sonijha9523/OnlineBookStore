using System.Collections.Generic;
using System.Linq;

using BookStoreWebService.Models.BookDB;

namespace BookStoreWebService.Models
{
    public class BookService
    {
        BookStoreDBContext context;
        public BookService()
        {
            context = new BookStoreDBContext();
        }
        public int AddNewOrder(Orders order)
        {

            context.Orders.Add(order);
            int result = context.SaveChanges();
            return result;

        }
        public List<Book> SearchBooks(SubCategory s)
        {       
            
              var result = (from b in context.Book where b.CategoryId==s.CategoryId && b.SubCategoryId==s.SubCategoryId select b ).ToList();
            return result;
        }
        public List<Category> SelCategory()
        {

            var result = (from c in context.Category select c).ToList();
            return result;
        }

        public List<SubCategory> SelSubCategory(int cid)
        {
            var result = (from c in context.SubCategory where c.CategoryId == cid select c).ToList();
            return result;
        }
        public List<Book> AllBooks()
        {
            var result = (from b in context.Book select b).ToList();
            return result;
        }
        public List<Book> GetBookById(int id)
        {
            var result = (from b in context.Book where b.BookId == id select b).ToList();
            return result;
        }
        public List<Book> GetAllBookByCat(int id)
        {
            var result = (from b in context.Book where b.CategoryId== id select b).ToList();
            return result;

        }
    }
}
