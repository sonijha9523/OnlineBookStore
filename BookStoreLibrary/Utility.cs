using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreLibrary
{
    public class ProductViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public override bool Equals(object obj)
        {
            return ((ProductViewModel)obj).BookId == BookId;
        }
        public override int GetHashCode()
        {
            return BookId.GetHashCode();
        }
    }
    public class ProductViewModelCart : ProductViewModel
    {
        public int Quantity { get; set; }
        public override bool Equals(object obj)
        {
            return ((ProductViewModelCart)obj).BookId == BookId;
        }
        public override int GetHashCode()
        {
            return BookId.GetHashCode();
        }
    }
    public class ProcessOrder : ProductViewModelCart
    {
        public int date { get; set; }
        public int sum { get; set; }
    }
    public class ReorderLevelDetails
    {
        public int BookId { get; set; }
        public int Quantity { get; set; }
    }
}
