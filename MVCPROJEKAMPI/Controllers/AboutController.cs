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
    public class AboutController : Controller
    {
        // GET: About
        AboutManager abm = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var aboutvalues = abm.GetAboutList();
            return View(aboutvalues);
        }
        
        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            abm.AboutAddBL(about);
            return RedirectToAction("Index");
        }

        public PartialViewResult AboutPartial()
        {
            //Biz normalde ekleme listeleme silme vb gibi işlemlerinin her biri için
            //farklı ActionResultlar ve Viewler tanımladık. Solid prensibinde böyle olmalı.
            //Ama burada hem eklemeyi hem de listelemeyi Index de tanımladık
            //burada devreye partialview giriyor
            //partial viewi yukarıdakı index view içinde çağırmak ıstedıgımız yere eklıyoruz ve solidi ezmemiş oluyoruz
            return PartialView();
        }
    }
}