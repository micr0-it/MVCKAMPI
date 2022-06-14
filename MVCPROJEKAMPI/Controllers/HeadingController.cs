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
    public class HeadingController : Controller
    {
        // GET: Heading
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingvalues = hm.GetHeadingList();
            return View(headingvalues);
        }
        
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valuecategory = (from x in cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName, 
                                                      Value= x.CategoryID.ToString()
                                                  }).ToList();
            //linq sorgusu amacımız : başlık ekleme işlemi gerçekleştirirken o başlığa ait kategori listesini getirmek.   //Text Deme sebebimiz verileri drpdowndan alcaz
            //iki parametresi var valuemember(value)  = seçmiş olunan id ; displaymember(Text) = seçilmiş olunanın adı 
            List<SelectListItem> valuewriter=(from x in wm.GetList()
                                              select new SelectListItem
                                              {
                                                  Text= x.WriterName + " " + x.WriterSurname, 
                                                  Value=x.WriterID.ToString() 
                                              }).ToList();
            ViewBag.vlw = valuewriter;
            ViewBag.vlc = valuecategory; // yukarıdakıki valuecategoryi view'a almayı başardık !
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAddBL(heading);
            return RedirectToAction("Index");
        }
    }
}