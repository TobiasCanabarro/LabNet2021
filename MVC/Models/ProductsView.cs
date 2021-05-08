using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ProductsView
    {
        public int Id { set; get;}
        public string ProductName { set; get;}
        public decimal? UnitPrice { set; get;}
        public short? UnitsInStock { set; get;}
    }
}