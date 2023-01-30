using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class PreRegister:BaseEntity
    {
        public PreRegister()
        {
        }

        //****SchoolNumber*****
        //Şimdiye kadar Okul No bilgisini, manuel olarak giriyorduk.Şimdi bunu programın otomatik olarak atamasını istiyoruz.Şöyle ki numaralarımız temelde 100’den başlayarak ardışık gider.Ancak biz, numaralarda şişme olmaması açısından, her numaranın sonuna kayıt yılının son iki hanesini ekleriz.Örnek vermek gerekirse; 2006 yılında verilen ilk numara, evrak üzerinde 100-06 olarak görünür.
        public int SchoolNumber { get; set; }
        public string StudentFullName { get; set; }
        public string Gender { get; set; }
        public string GraduatedSchool { get; set; }
        public decimal GPA { get; set; }
        public string ParentFullName { get; set; }
        public string HomeNumber { get; set; }
        public string WorkNumber { get; set; }
        public string HomeAddress { get; set; }
        public string ProvinceDistrict { get; set; }

        //Relational Properties
        public virtual Student Student { get; set; }
    }
}
