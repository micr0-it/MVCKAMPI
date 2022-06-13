using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategoryList();
        void CategoryAddBL(Category category);
        Category GetByID(int id);
        void CategoryDelete(Category category); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne seıt o yuzden burda category idsi aldık
        void CategoryUpdate(Category category); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne seıt o yuzden burda category idsi aldık
        
    }
}
