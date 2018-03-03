using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiDoner.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string PictureUrl { get; set; }

        public bool IsActive { get; set; }

        public bool IsHomePageCategory { get; set; }

    }
}