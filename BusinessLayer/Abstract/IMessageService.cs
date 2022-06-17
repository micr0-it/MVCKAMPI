using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {
        List<Message> GetMessageList();
        void MessageAddBL(Message message);
        Message GetByID(int id);
        void MessageDelete(Message message); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne seıt o yuzden burda category idsi aldık
        void MessageUpdate(Message message); // id ile bilgileri aldık o bilgiler direk catogry nesnesıne seıt o yuzden burda category idsi aldık
    }
}
