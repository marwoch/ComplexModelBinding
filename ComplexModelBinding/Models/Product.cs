using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplexModelBinding.Models
{
    public class Product
    {
        [Key]
        [Display( Name ="Product Id")]
        public int ProductId { get; set; }

        public double Price { get; set; }

        public string Name { get; set; }
    }

    public class CartItem
    {
        [Display(Name ="Product Id")]
        public int ProductId { get; set; }

        public short Quantity { get; set; }
    }
}