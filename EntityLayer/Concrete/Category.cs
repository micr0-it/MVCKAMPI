using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(200)]
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }//İçeriklerin Başlıkların Silinmemesi İçin Durumu Pasif Hale Getirdik

        //İlişki Tanımlıyoryuz - Heading ile - Bire Çok -Heading tarafında da düzenle
        public ICollection<Heading> Headings { get; set; }
    }
}
