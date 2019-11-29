using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kendo.Mvc.UI;

namespace KendoUIMVCAPI.Models
{
    public class Customer
    {
        public Customer(int customerID, string customerName, string catergory, string startDate, string email, bool isActive)
        {
            this.CustomerID = customerID;
            this.CustomerName = customerName;
            this.Catergory = catergory;
            this.Email = email;
            this.isActive = isActive;
        }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Catergory { get; set; }

        public string Email { get; set; }
        public bool isActive { get; set; }
    }
}