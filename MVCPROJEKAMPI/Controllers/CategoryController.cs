using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
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
            return RedirectToAction("GetCategoryList");
        }
    }

}