using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiDoner.Models
{
    public class Product
    {

        //public Product()
        //{

        //}

        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        public bool IsActive { get; set; }

    }
}