using System;
using System.Collections.Generic;
using System.Text;

namespace BookStoreLibrary
{
   public class FinalOrder
    {
        public ProductViewModelCart[] products { get; set; }
        public int CustomerId { get; set; }
        public string PaymentMethod { get; set; }
    }
}
