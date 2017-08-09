using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplexModelBinding.Models
{
    public class Order
    {
        public Order()
        {
            CartItems = new List<CartItem>();
        }

        [Key]
        [Display(Name = "Order Id")]
        public int OrderId { get; set; }

        public DateTime Date { get; set; }

        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }

        public double Total { get; set; }

        //public List<Product> Products { get; set; }
        [Display(Name = "Cart Items")]
        public List<CartItem> CartItems { get; set; } //defaults to null. object constructer can make sure not null
    }
}