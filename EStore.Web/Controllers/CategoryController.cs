using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EStore.Entities;
using EStore.Services;

namespace EStore.Web.Controllers
{
    public class CategoryController : Controller
    {
        CategoryServices CategoryServices = new CategoryServices();



        [HttpGet]
        public ActionResult GetCategory()
        {
            var catData = CategoryServices.Getcategory();
            return View(catData);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            CategoryServices.Savecategory(category);
            return RedirectToAction("GetCategory");
        }



        [HttpGet]
        public ActionResult Edit(int catID)
        {
            var catData = CategoryServices.Editcategory(catID);
            return View(catData);
        }

        [HttpPost]
        public ActionResult Edit(Category category)
        {
             CategoryServices.Updatecategory(category);
            return RedirectToAction("GetCategory");
        }

   
        public ActionResult Delete(Category category)
        {
            CategoryServices.Deletecategory(category.ID);
            return RedirectToAction("GetCategory");
        }

    }
}