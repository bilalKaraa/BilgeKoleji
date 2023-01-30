using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Classroom:BaseEntity
    {
        public Classroom()
        {
        }
        public string Capacity { get; set; }

        //Relational Properties
        public virtual List<Teacher> Teachers { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
