﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ComplexModelBinding.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }


    }
}