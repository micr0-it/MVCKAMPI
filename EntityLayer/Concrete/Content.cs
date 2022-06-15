using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }
        
        [StringLength(1000)]
        public string ContentText { get; set; }
        public DateTime ContentDate { get; set; }
        public bool ContentStatus { get; set; }


        // İlişki Yakalama 
        public int HeadingID { get; set; }
        
        //iLİŞKİ ÇERİSNDE OLUP OLMADIĞINI BELİRLERDİK
        public virtual Heading Heading { get; set; }
        
        //NullEnable Type
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
