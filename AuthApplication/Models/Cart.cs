using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthApplication.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public Cart(int quantity,Product product)
        {
            Product = product;
            Quantity = quantity;
        }
        public Cart()
        {

        }
    }
}
