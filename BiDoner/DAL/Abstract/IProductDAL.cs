﻿using BiDoner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiDoner.DAL.Abstract
{
    public interface IProductDAL : IBaseDAL<Product>
    {
        IEnumerable<Product> GetActiveProducts();

    }
}
