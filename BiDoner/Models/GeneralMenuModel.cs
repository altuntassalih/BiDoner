using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiDoner.Models
{
    public class GeneralMenuModel
    {
        public IEnumerable<Category> CategoryList { get; set; }

        public IEnumerable<Product> ProductList { get; set; }
    }
}