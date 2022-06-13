using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPROJEKAMPI.Controllers
{
    public class AdminCategoryController : Controller
    {
        // GET: AdminCategory
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            var categoryvalues = cm.GetCategoryList();
            return View(categoryvalues);
        }
        
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator validator = new CategoryValidator();
            ValidationResult results = validator.Validate(p);
            if (results.IsValid)
            {
                cm.CategoryAddBL(p);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public ActionResult DeleteCategory(int id) //viewi olmayacak index üzerinden çağırılacak
        {
            var categoryvalue = cm.GetByID(id);
            cm.CategoryDelete(categoryvalue);
            return RedirectToAction("Index");
        }

        
        
        //Update için iki adım var
        //1.Güncellencek Bilgilerin Güncelleme Sayfasına Taşınması
        //2.Güncelleme İşleminin yapılması
        
        [HttpGet]
        public ActionResult EditCategory(int id) //viewi olmayacak index üzerinden çağırılacak
        {
            var categoryvalue = cm.GetByID(id);
            return View(categoryvalue); //Değişkenin içeriği geldi
        }


        [HttpPost]
        public ActionResult EditCategory(Category p) //viewi olmayacak index üzerinden çağırılacak
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }
    }
}