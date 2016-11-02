using MVCStarter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCStarter.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            ViewBag.SomeMessage = "This is a message from the controller";
            List<Product> products = new List<Product>();
            products.Add(new Product() { ProductID = 1, ProductName = "Product 1" });
            products.Add(new Product() { ProductID = 2, ProductName = "Product 2" });
            products.Add(new Product() { ProductID = 3, ProductName = "Product 3" });

            return View(products);
        }
    }
}