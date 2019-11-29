using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoUIMVCAPI.Models;

namespace KendoUIMVCAPI.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProductList([DataSourceRequest]DataSourceRequest request)
        {
            List<Product> lstProduct = new List<Product>();
            // mocked API response here
            lstProduct.Add(new Product(1, "Product1", 2300));
            lstProduct.Add(new Product(2, "Product2", 2500));
            DataSourceResult result = lstProduct.ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public async System.Threading.Tasks.Task<ActionResult> CustomerList([DataSourceRequest]DataSourceRequest request)
        {
            try
            {
                List<Customer> lstCustomer = new List<Customer>();
                // RESTFul API call to get customer data
                string apiUrl = "http://localhost:4000/api/v1/customers";

                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                   
                        var data = await response.Content.ReadAsStringAsync();
                        //deserialize the API JSON response to customer object
                        lstCustomer = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Customer>>(data);
                        DataSourceResult result = lstCustomer.ToDataSourceResult(request);
                        return Json(result, JsonRequestBehavior.AllowGet);
                                      
                }
                
            }
            catch (Exception ex)
            {
                return Json(ex.Message, JsonRequestBehavior.AllowGet);

            }
        }
        
    }
}