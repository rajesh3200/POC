using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Models
{
    public class FeaturedProduct
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public decimal Price { get; set; }
    }
}