using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Teacher:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Aassignment { get; set; }
        public string Branch { get; set; }

        //Relational Properties
        public virtual List<Student> Students { get; set; }
        public virtual List<Classroom> Classrooms { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
