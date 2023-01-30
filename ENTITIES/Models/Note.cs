using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Note:BaseEntity
    {
        public Note()
        {

        }

        //Relational properties
        public virtual List<Student> Students { get; set; }
    }
}
