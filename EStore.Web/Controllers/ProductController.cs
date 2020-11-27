using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EStore.Services;
using EStore.Entities;

namespace EStore.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductServices productServices = new ProductServices();

        [HttpGet]
        public ActionResult Create()
        {          
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            productServices.Saveproducts(product);
            return RedirectToAction("GetProduct");
        }



        public ActionResult GetProduct()
        {
          var proList=  productServices.Getproducts();
            return View(proList);
        }


  
        public ActionResult Edit(int productID)
        {
           var product= productServices.EditProducts(productID);
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            productServices.UpdateProducts(product);
            return RedirectToAction("GetProduct");
        }

        public ActionResult Delete(Product  product)
        {
            productServices.DeleteProducts(product.ID);
            return RedirectToAction("GetProduct");
        }


    }
}