using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetAboutList();
        About GetByID(int id);
        void AboutDelete(About about); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne esit o yuzden burda category idsi aldık
        void AboutUpdate(About about); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne eşit o yuzden burda category idsi aldık

    }
}
