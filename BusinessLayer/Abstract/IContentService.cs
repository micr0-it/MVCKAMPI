using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetContentList(); 
        List<Content> GetListByHeadingID(int id);  // Başlığa Göre Tüm Liste
                                            // SELECT * FROM Contents where HeadingID
                                            // HeadingID ise o başlıklar kısmında yazılara tıklıyoruz ya oradan gelcek
        void ContentAddBL(Content content);
        Content GetByID(int id);
        void ContentDelete(Content content); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne esit o yuzden burda category idsi aldık
        void ContentUpdate(Content content); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne eşit o yuzden burda category idsi aldık

    }
}
