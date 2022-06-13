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
    public class CategoryController : Controller
    {
        // GET: Category
        //CategoryManagerı kullanıyoruz bl den 
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
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
            //cm.CategoryAddBL(p);
            CategoryValidator validator = new CategoryValidator();
            ValidationResult results = validator.Validate(p); // burada result degıskenı categoryvalidator sınıfında olan degerlere gore parametremızdeki dogruluk kotnrolune bakıcaz
            if (results.IsValid)
            {
                cm.CategoryAddBL(p);
                return RedirectToAction("GetCategoryList");
            }
            else
            {
                foreach (var item in results.Errors)//hata mesajlarının tutuldugu dızın
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }

}