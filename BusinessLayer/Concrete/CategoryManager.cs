using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal; //Atama yapabilmem için yapıcı metot lazım ! GenericRepoda yapmıstık !

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public List<Category> GetCategoryList()
        {
            return _categorydal.List();
            //Neden GenericRepository Fonksiyonları Geldi ?
            //Çünkü yukarda ICategoryDal kullanıldı o da IRepositoryden kalıtılıyor
        }



    }
}
