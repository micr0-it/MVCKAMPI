using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService 
    {
        List<Heading> GetHeadingList();
        void HeadingAddBL(Heading heading);
        Heading GetByID(int id);
        void HeadingDelete(Heading heading); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne esit o yuzden burda category idsi aldık
        void HeadingUpdate(Heading heading); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne eşit o yuzden burda category idsi aldık
    }
}
