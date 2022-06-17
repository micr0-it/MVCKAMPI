using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetContactList();
        void ContactAddBL(Contact contact);
        Contact GetByID(int id);
        void ContactDelete(Contact contact); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne seıt o yuzden burda category idsi aldık
        void ContactUpdate(Contact contact); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne seıt o yuzden burda category idsi aldık

    }
}
