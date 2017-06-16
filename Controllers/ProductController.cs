using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Basic_Crud_With_EFCore.Utilities;
using Basic_Crud_With_EFCore.Models;

namespace Basic_Crud_With_EFCore.Controllers
{
    public class ProductController : Controller
    {
        MSSQLDbContext DBContext;
        public ProductController(MSSQLDbContext context)
        {
            DBContext = context;
        }
        [HttpPost]
        public IActionResult Create()
        {
            List<OrderProduct> OP = new List<OrderProduct> ();
            OP.Add(new OrderProduct { Order = DBContext.Orders.Find((long)1)});
            Product product = new Product
            {
                Name = "Test",
                Description = "Tasty",
                Price = 10,
                Type = "T",
                CreateTime = DateTime.Now,
                UpdateTime = DateTime.Now,
                Orders = OP
            };

            DBContext.Products.Add(product);
            DBContext.SaveChanges();

            return Json(new
            {
                success=true
            });
        }

        public IActionResult List()
        {
           var products = DBContext.Products.Skip(0).Take(20).ToList();

            return View(products);
        }

        public IActionResult Delete(long Id)
        {
            var product = DBContext.Products.Find(Id);
            DBContext.Products.Remove(product);
            DBContext.SaveChanges();
            return Json(new
            {
                success = true
            });
        }

        [HttpPost]
        public IActionResult Update(long Id)
        {
            var product = DBContext.Products.Find(Id);
            product.Name = "UpdatedTest";
            DBContext.SaveChanges();

            return Json(new
            {
                success = true
            });
        }
    }
}
