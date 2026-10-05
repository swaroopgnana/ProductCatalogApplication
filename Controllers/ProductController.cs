using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class ProductController : Controller
    {
        public string Category { get; private set; }
        public int Price { get; private set; }
        public string Description { get; private set; }
        public string ProductName { get; private set; }
        public int ProductId { get; private set; }

        // GET: Product
        public ActionResult Index()
        {
            List<Product> P = new List<Product>();
            P = GetProducts();
            return View(P);
        }





        public ActionResult Details(int id)
        {
            List<Product> PALL = GetProducts();
            Product P1 = PALL.FirstOrDefault(p => p.ProductId == id);
            return View(P1);
        }

        private List<Product> GetProducts()
        {

            return new List<Product> {
            new Product
            {

                ProductId=1,
                ProductName = "Laptop",
                Description = "MAC",
                Price = 55000,
                Category = "Electronics"
            },
            new Product
            {

                ProductId=2,
                ProductName = "Mobile",
                Description = "Iphone 18 Pro Max",
                Price = 250000,
                Category = "Electronics"
            },
              new Product
            {

                ProductId=3,
                ProductName = "Mobile",
                Description = "Redmi 13C 5G",
                Price = 50000,
                Category = "Electronics"
            },
                new Product
            {

                ProductId=4,
                ProductName = "Tablets",
                Description = "Samsung",
                Price = 25000,
                Category = "Electronics"
            }


            };

        }



    }
}
