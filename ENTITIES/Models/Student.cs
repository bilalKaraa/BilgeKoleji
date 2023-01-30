using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITIES.Models
{
    public class Student:BaseEntity
    {
        public Student()
        {
        }
        public string Class { get; set; }
        public string Section { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Absenteeism { get; set; }

        //Relational Properties
        
        public virtual PreRegister PreRegister { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
        public virtual Classroom Classroom { get; set; }
        public virtual List<Note> Notes { get; set; }
        public virtual List<Document> Documents { get; set; }
    }
}
