using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Document:BaseEntity
    {
        public Document()
        {

        }
        public string CertificateOfAppreciation { get; set; }//teşekkür
        public string CertificateOfHonour { get; set; }//onur
        public string LeavingCertificate { get; set; }//tasdikname
        public string CertificateOfAchievement { get; set; }//takdir

        //Relational Properties
        public virtual List<Student> Students { get; set; }

    }
}
