using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kendo.Mvc.UI;

namespace KendoUIMVCAPI.Models
{
    public class Product
    {
        public Product(int ProductID, string ProductName, int Price)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}