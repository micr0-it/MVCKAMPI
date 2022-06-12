using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int HeadingID { get; set; }
        [StringLength(50)]
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }
        //Contentle birleştircez

        // İlişki Yakalama 
        public int CategoryID { get; set; } // DATABASE FIRSTTEKİ FK MANTIĞI
        
        //iLİŞKİ ÇERİSNDE OLUP OLMADIĞINI BELİRLERDİK
        public virtual Category Category { get; set; }
       
        //İLİŞKİ YAKALAMA
        public int WriterID { get; set; }
        //iLİŞKİ ÇERİSNDE OLUP OLMADIĞINI BELİRLERDİK
        public virtual Writer Writer { get; set; }

        //İlişki Tanımlıyoryuz - Content ile - Bire Çok - Content tarafında da düzenle

        public ICollection<Content> Contents { get; set; }

        
    }
}
